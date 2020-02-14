using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

//Gestion des différents evenements

namespace tp2048
{
    partial class Jeu
    {
        //Traitement de la victoire
        public event EventHandler Fusion2048;
        protected virtual void onFusion2048(EventArgs e)
        {
            Logs.Info("FUSION 2048");
            Fusion2048?.Invoke(this, e);
        }
        private void Victoire(object sender, EventArgs e)
        {
            Affiche();
            MessageBox.Show("Victoire !", "GGWP");
        }
        //Traitement de la défaite
        public event EventHandler GameOver;
        protected virtual void onGameOver(EventArgs e)
        {
            Logs.Info("GAME OVER");
            GameOver?.Invoke(this, e);
        }
        private void Defaite(object sender, EventArgs e)
        {
            Affiche();
            MessageBox.Show("Défaite...", "Looser");
        }
        //Initialisation du jeu
        public Jeu()
        {
            InitializeComponent();
            Fusion2048 += new System.EventHandler(Victoire);
            GameOver += new System.EventHandler(Defaite);
            _case = testp9.testP9();
            Affiche();
        }
        private void LabelEtat_Click(object sender, EventArgs e)
        {
            MessageEtat("Version 2.0");
        }

        private void NouveauJeu_Click(object sender, EventArgs e)
        {
            Logs.Warn("Nouvelle partie");
            MessageEtat("Nouvelle partie");
            Logs.Debug("Nouvelle partie");
            ajoutValeur();
            Affiche();
        }

        //Traitement touche appuyé
        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            Sens touche = Direction(e);
            MessageEtat($"Touche {touche}");
            (bool caseDeplacee, int score) = Bouge(touche);
            if (caseDeplacee)
            {
                _score += score;
                _mouvements += 1;
                ajoutValeur();
                Affiche();
                Blocage();
            }
        }
        private void Blocage()
        {
            bool mouvementImpossible = true;
            int i = 0;
            int j = 0;
            int num = 0;
            
            while (mouvementImpossible && (num<=15))
            {
                i = (int)num / 4;
                j = num % 4;

                if ((_case[i,j]==0)//case vide ?
                    || (i >= 1 && _case[i - 1, j] == _case[i, j]) //même valeur à Gauche ?
                    || (i <= 2 && _case[i + 1, j] == _case[i, j]) //même valeur à Droite ?
                    || (j >= 1 && _case[i, j - 1] == _case[i, j]) //même valeur en Haut ?
                    || (j <= 2 && _case[i, j + 1] == _case[i, j])) //même valeur en Base
                {
                    mouvementImpossible = false;
                }
                num += 1;
            }
            if (mouvementImpossible)
            {
                EventArgs args = new EventArgs();
                onGameOver(args);
            }
        }
        //Fermeture du jeu
        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Fermeture ?");
            e.Cancel = MessageBox.Show(String.Format($"{Environment.UserName} souhaite prendre la fuite, vous confirmez ?")/*e.CloseReason*/ , "Poule mouillé", MessageBoxButtons.YesNo) == DialogResult.No;
            Logs.Debug("Fermeture en cours");
        }
        private void Jeu_Load(object sender, EventArgs e)
        {
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Démarrage du programme");
            SqlDB.Instance().ExecSQL($"INSERT OR IGNORE INTO `utilisateur` (pseudo) VALUES ('{Environment.UserName}')");
        }
    }
}
