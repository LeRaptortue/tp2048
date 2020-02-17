using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace tp2048
{
    class SqlDB
    {
        private static SqlDB _instance = null;
        private string _db = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp\\2048\\2048.db";
        private SqlDB()
        {
            if (!File.Exists(_db))
            {
                if (!DbCreation())
                {
                    throw new FileNotFoundException($"Fichier de données SQLite {_db} non trouvé");
                }
            }
        }

        public static SqlDB Instance()
        {
            if (_instance==null)
            {
                _instance = new SqlDB();
            }
            return _instance;
        }
        private bool DbCreation()
        {
            try { SQLiteConnection.CreateFile(_db); }
            catch (SQLiteException e){
                MessageBox.Show(e.Message);
                return false;
            }
            using (SQLiteConnection connexion = new SQLiteConnection())
            {
                using (SQLiteCommand query = new SQLiteCommand())
                {
                    connexion.ConnectionString = $"DataSource={_db};Version=3;New=False;Compress=True;";
                    connexion.Open();
                    query.Connection = connexion;
                    query.CommandText = "CREATE TABLE jeu (uid INTEGER NOT NULL, terminal STRING NOT NULL, points INTEGER NOT NULL, mouvements INTEGER NOT NULL, cases VARCHAR(15) NOT NULL, UNIQUE (uid, terminal)); CREATE TABLE score(uid INTEGER NOT NULL, points INTEGER NOT NULL, instant DATETIME, UNIQUE(uid, instant)); CREATE TABLE utilisateur(uid INTEGER PRIMARY KEY AUTOINCREMENT, pseudo STRING NOT NULL UNIQUE, prenom STRING, nom STRING, mdp STRING); ";
                    query.ExecuteNonQuery();
                    connexion.Close();
                }
            }
            return true;
        }
        public void ExecSQL(string[] insertions)
        {
            string _connect = $"DataSource={_db};Version=3;New=False;Compress=True;";
            using (SQLiteConnection cn = new SQLiteConnection(_connect))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
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

        public DataSet LitSQL(string requete, string table)
        {
            DataSet donnees = new DataSet();
            var connexion = new SQLiteConnection($"DataSource=C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp\\2048\\2048.db;Version=3;New=False;Compress=True;");
            var commande = new SQLiteCommand(requete, connexion);
            var adaptateur = new SQLiteDataAdapter(commande);
            adaptateur.Fill(donnees, table);
            return donnees;
        }
    }
}
