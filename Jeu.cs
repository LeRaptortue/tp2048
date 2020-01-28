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
        private int[,] _case = new int[4, 4];
        public Jeu()
        {
            InitializeComponent();
            _case[1, 1] = 2;
            _case[2, 2] = 4;
            _case[2, 0] = 16;
            Case11.Text = _case[1, 1].ToString();
            Case22.Text = _case[2, 2].ToString();
            Case33.Text = _case[2, 0].ToString();
            //Case20.BackColor = Outils.Couleurs(_case[2, 0])["fond"];
            //Case20.ForeColor = Outils.Couleurs(_case[2, 0])["fonte"];
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Démarrage du programme");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MessageEtat(string message)
        {
            LabelEtat.Text = message;
        }
        private void LabelEtat_Click(object sender, EventArgs e)
        {
            MessageEtat("Version 1.0");
        }

        private void NouveauJeu_Click(object sender, EventArgs e)
        {
            MessageEtat("Nouvelle partie");
            LabelMouvement.Text = _mouvements.ToString();
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Nouvelle partie");
        }

        private void Jeu_KeyDown(object sender, KeyEventArgs e)
        {
            Sens touche = Direction(e);
            MessageEtat($"Touche {touche}");
            if(Bouge(touche))
            {
                _mouvements+=1;
                Affiche();
            }
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
            LabelMouvement.Text = _mouvements.ToString();
        }
        public enum Sens
        {
            Haut, Bas, Droite, Gauche, Autre
        }
        private Sens Direction(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down: return Sens.Bas;
                case Keys.Up: return Sens.Haut;
                case Keys.Left: return Sens.Gauche;
                case Keys.Right: return Sens.Droite;
                default: return Sens.Autre;
            }
        }
        private bool Bouge(Sens s)
        {
            bool caseDeplacee = false;
            switch(s)
            {
                case Sens.Droite:
                    for (int j = 0; j <= 3; j += 1)
                    {
                        for (int i = 2; i >= 0; i -= 1)
                        {
                            if ((_case[i + 1, j] == 0) && (_case[i, j] != 0))
                            {
                                _case[i + 1, j] = _case[i, j];
                                _case[i, j] = 0;
                                caseDeplacee = true;

                                log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
                                log4net.Config.XmlConfigurator.Configure();
                                Logs.Debug("Déplacement à droite");
                            }
                        }
                    }
                    return caseDeplacee;
                case Sens.Gauche:
                    for (int j = 0; j <= 3; j += 1) //int i =2;i>=0; i-=1
                    {
                        for(int i = 1; i <= 3; i += 1) //int j=0;j<=3;j+=1
                        {
                            if ((_case[i - 1, j] == 0) && (_case[i, j] != 0))
                            {
                                _case[i - 1, j] = _case[i, j];
                                _case[i, j] = 0;
                                caseDeplacee = true;

                                log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
                                log4net.Config.XmlConfigurator.Configure();
                                Logs.Debug("Déplacement à gauche");
                            }
                        }
                    }
                    return caseDeplacee;
                case Sens.Bas:
                    for (int j = 2; j >=0; j -= 1)
                    {
                        for (int i = 0; i <= 3; i += 1)
                        {
                            if ((_case[i, j+1] == 0) && (_case[i, j] != 0))
                            {
                                _case[i, j+1] = _case[i, j];
                                _case[i, j] = 0;
                                caseDeplacee = true;

                                log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
                                log4net.Config.XmlConfigurator.Configure();
                                Logs.Debug("Déplacement en bas");
                            }
                        }
                    }
                    return caseDeplacee;
                case Sens.Haut:
                    for (int j = 1; j <= 3; j += 1)//int j = 2; j >= 0; j += 1
                    {
                        for (int i = 0; i <=3; i += 1)//int i = 0; i <= 3; i += 1
                        {
                            if ((_case[i, j - 1] == 0) && (_case[i, j] != 0))
                            {
                                _case[i, j - 1] = _case[i, j];
                                _case[i, j] = 0;
                                caseDeplacee = true;

                                log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
                                log4net.Config.XmlConfigurator.Configure();
                                Logs.Debug("Déplacement en Haut");
                            }
                        }
                    }
                    return caseDeplacee;
                case Sens.Autre:
                    return caseDeplacee;
            }

            return caseDeplacee;
        }


        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Fermeture ?");
            e.Cancel = MessageBox.Show(
                String.Format("Fermeture de l'application demandée pour {0}. Voulez-vous quitter ?",
                e.CloseReason), "Fermeture...",
                MessageBoxButtons.YesNo) == DialogResult.No;

            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Fermeture en cours");
        }
    }
}
