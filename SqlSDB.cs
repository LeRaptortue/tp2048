using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace tp2048
{
    class SqlSDB
    {
        private static SqlSDB _instance;
        private SqlConnectionStringBuilder _builder;
        private SqlConnection _connection;

        private SqlSDB()
        {
            _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = "192.168.233.143";
            _builder.UserID = "sa";
            _builder.Password = "159753moiU";
            _builder.InitialCatalog = "2048";

            try
            {
                _connection = new SqlConnection(_builder.ToString());
                _connection.Open();
                Logs.Debug("connexion SQL Server Reussi");
            }
            catch (SqlException e)
            {
                Logs.Fatal("Connexion à la base SQL Server Impossible :" + e.Message);
                MessageBox.Show("Connexion à la base SQL Server Impossible :" + e.Message);
            }
        }

        public static SqlSDB Instance()
        {
            if (_instance == null)
            {
                _instance = new SqlSDB();
            }
            return _instance;
        }

        public void ExecSQL(string[] insertions)
        {
            string _connection = "Data Source = 192.168.233.143; Network Library=DBMSSOCN; Initial Catalog = 2048; User ID = sa; Password = 159753moiU";
            using (SqlConnection cn = new SqlConnection(_connection))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    foreach (string insertion in insertions)
                    {
                        cmd.CommandText = insertion;
                        cmd.Connection = cn;
                        try { cmd.ExecuteNonQuery(); }
                        catch (Exception ex) { MessageBox.Show($"Erreur d'insertion pour {insertion} : {ex.Message}"); }
                    }
                }
                cn.Close();
            }
        }

        public void ExecSQL(string insertion)
        {
            ExecSQL(new string[1] { insertion });
        }
        public DataSet SqlServer(string requete, string table)
        {
            DataSet donnees = new DataSet();
            var connexion = new SqlConnection($"Data Source = 192.168.233.143; Network Library=DBMSSOCN; Initial Catalog = 2048; User ID = sa; Password = 159753moiU");
            var commande = new SqlCommand(requete, connexion);
            var adaptateur = new SqlDataAdapter(commande);
            adaptateur.Fill(donnees, table);
            return donnees;
        }
    }
}
