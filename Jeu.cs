using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace tp2048
{
    public partial class Jeu : Form
    {
        private int _mouvements = 0;
        private int _score = 0;
        private const int _scoreMinEngregistrement = 500;
        private int[,] _case = new int[4, 4];

        private void MessageEtat(string message)
        {
            LabelEtat.Text = message;
        }
        private void ajoutValeur()
        {
            (int i, int j, int val) = Outils.aleaCase(_case);
            _case[i, j] = val;
        }
        public void Affiche(int x, int y)
        {
            var ctrl = Grille.Controls.Find($"Case{x}{y}", true)[0];
            ctrl.Text = (_case[x, y] == 0) ? "" : _case[x, y].ToString();
            var couleur = Outils.Couleurs(_case[x, y]);
            ctrl.BackColor = couleur["fond"];
            ctrl.ForeColor = couleur["fonte"];
        }
        private void Affiche()
        {
            for(int i = 0; i<=3; i+=1)
            {
                for(int j = 0; j<= 3; j+=1)
                {
                    Affiche(i, j);
                }
            }
            LabelScore.Text = _score.ToString();
            LabelMouvement.Text = _mouvements.ToString();
        }

        private void àProposDu2048ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aPropos = new aPropos();
            aPropos.StartPosition = FormStartPosition.CenterParent;
            aPropos.ShowDialog();
        }
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((_score > _scoreMinEngregistrement)
                && (MessageBox.Show($"Enregistrer le score de {_score} point pour {Environment.UserName} ?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                SqlDB.Instance().ExecSQL($"INSERT INTO score (uid, points, instant) VALUES((SELECT uid FROM utilisateur WHERE pseudo ='{Environment.UserName}'), { _score}, DATETIME('now'))");
            }
            else
            {
                MessageBox.Show($"Vous êtes sérieux là ? Votre score n'est que de {_score} !" 
                    + Environment.NewLine
                    + $"Il faut au moins {_scoreMinEngregistrement} points pour pouvoir prétendre appartenir au Panthéon des Vainqueurs !"
                    + Environment.NewLine
                    + Environment.NewLine 
                    + "Minable..","",MessageBoxButtons.OK);
            }
        }

        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var score = new score();
            score.StartPosition = FormStartPosition.CenterParent;
            score.ShowDialog();
        }


        private void sauvegarderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(saveStr(_case));

            string saveString = Outils.SaveStr(_case);
            string requeteSave = $"INSERT OR REPLACE INTO jeu (uid, terminal, points, mouvements, cases) VALUES ((SELECT uid FROM utilisateur WHERE pseudo ='{Environment.UserName}'), '{Environment.MachineName}', {_score}, {_mouvements}, '{saveString}');";
            bool partieExistante = false;
            // Récup date de sauvegarde précédente
            DataSet donnees = SqlDB.Instance().LitSQL($"SELECT COUNT(*) AS partie, points FROM jeu WHERE uid=(SELECT uid FROM utilisateur where pseudo='{Environment.UserName}') AND terminal='{Environment.MachineName}'", "jeu");
            if (donnees.Tables["jeu"].Rows[0]["partie"].ToString() == "1")
            {
                partieExistante = true;
            }

            //Confirmation
            if (!partieExistante || MessageBox.Show($"Ecraser la partie existante à {donnees.Tables["jeu"].Rows[0]["points"].ToString()} points pour {Environment.UserName} ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlDB.Instance().ExecSQL(requeteSave);
            }
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet donnees = SqlDB.Instance().LitSQL($"SELECT COUNT(*) AS partie, points, mouvements, cases FROM jeu WHERE uid=(SELECT uid FROM utilisateur WHERE pseudo='{Environment.UserName}') AND terminal='{Environment.MachineName}'", "jeu");
            int jeu = int.Parse(donnees.Tables["jeu"].Rows[0]["partie"].ToString());
            if (jeu != 0)
            {
                _case = Outils.LoadStr(donnees.Tables["jeu"].Rows[0]["cases"].ToString());
                _mouvements = int.Parse(donnees.Tables["jeu"].Rows[0]["mouvements"].ToString());
                _score = int.Parse(donnees.Tables["jeu"].Rows[0]["points"].ToString());
                Affiche();
            }
            else
            {
                MessageBox.Show("Pas de partie sauvegardé");
            }    
        }
    }
}