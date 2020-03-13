using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2048
{
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {
            string requete = "SELECT points, pseudo, instant FROM score LEFT JOIN utilisateur ON utilisateur.uid = score.uid ORDER BY points DESC";
            DataSet donnees = SqlSDB.Instance().SqlServer(requete, "score");
            DataScores.DataSource = donnees.Tables["score"];
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
