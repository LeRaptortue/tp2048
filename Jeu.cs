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
        private int[,] _case = new int[4, 4];
        public Jeu()
        {
            InitializeComponent();
            //_case[0, 1] = 32;
            //Case01.Text = _case[0, 1].ToString();
            _case = testp9.testP9();
            Affiche();
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
            (bool caseDeplacee, int score) = Bouge(touche);
            if(caseDeplacee)
            {
                _score += score;
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
            LabelScore.Text = _score.ToString();
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
        private (bool, int) Bouge(Sens s)
        {
            bool caseDeplacee = false;
            int score = 0;
            bool[,] fusion= new bool[4,4];
            switch (s)
            {
                case Sens.Droite:
                    for (int j = 0; j <= 3; j += 1)
                    {
                        for (int i = 2; i >= 0; i -= 1)
                        {
                            if (_case[i, j] != 0)
                            {
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if ((_case[k + 1, j] == 0)
                                        || (! fusion[k + 1, j] && (_case[k + 1, j] == _case[i, j])))
                                    {
                                        liberte = k + 1;
                                    }
                                    k += 1;
                                } while ((k < 3) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    if (_case[liberte, j] == 0)
                                    {
                                        _case[liberte, j] = _case[i, j];
                                    } 
                                    else
                                    {
                                        _case[liberte, j] *= 2;
                                        score += _case[liberte, j];
                                        fusion[liberte, j] = true;
                                    }
                                    _case[i, j] = 0;
                                    caseDeplacee = true;
                                    Logs.Debug("Déplacement vers la droite");
                                }
                            }
                        }
                    }
                    return (caseDeplacee, score);
                case Sens.Gauche:
                    for (int j = 0; j <= 3; j += 1)
                    {
                        for (int i = 1; i <= 3; i += 1)
                        {
                            if (_case[i, j] != 0)
                            {
                                int k = i;
                                int liberte = i;
                                do
                                {
                                    if ((_case[k - 1, j] == 0)
                                        || (!fusion[k - 1, j] && (_case[k - 1, j] == _case[i, j])))
                                    {
                                        liberte = k - 1;
                                    }
                                    k -= 1;
                                } while ((k > 0) && (_case[k, j] == 0));
                                if (liberte != i)
                                {
                                    if (_case[liberte, j] == 0)
                                    {
                                        _case[liberte, j] = _case[i, j];
                                    }
                                    else
                                    {
                                        _case[liberte, j] *= 2;
                                        score += _case[liberte, j];
                                        fusion[liberte, j] = true;
                                    }
                                    _case[i, j] = 0;
                                    caseDeplacee = true;
                                    Logs.Debug("Déplacement vers la gauche");
                                }
                            }
                        }
                    }
                    return (caseDeplacee, score);
                case Sens.Bas:
                    for (int j = 2; j >= 0; j -= 1)
                    {
                        for (int i = 0; i <= 3; i += 1)
                        {
                            if (_case[i, j] != 0)
                            {
                                int k = j;
                                int liberte = j;
                                do
                                {
                                    if ((_case[i, k+1] == 0)
                                        || (!fusion[i, k+1] && (_case[i, k+1] == _case[i, j])))
                                    {
                                        liberte = k + 1;
                                    }
                                    k += 1;
                                } while ((k < 3) && (_case[i, k] == 0));
                                if (liberte != j)
                                {
                                    if (_case[i, liberte] == 0)
                                    {
                                        _case[i, liberte] = _case[i, j];
                                    }
                                    else
                                    {
                                        _case[i, liberte] *= 2;
                                        score += _case[i, liberte];
                                        fusion[i, liberte] = true;
                                    }
                                    _case[i, j] = 0;
                                    caseDeplacee = true;
                                    Logs.Debug("Déplacement vers le bas");
                                }
                            }
                        }
                    }

                    return (caseDeplacee, score);
                case Sens.Haut:
                    for (int j = 1; j <= 3; j += 1)
                    {
                        for (int i = 0; i <= 3; i += 1)
                        {
                            if (_case[i, j] != 0)
                            {
                                int k = j;
                                int liberte = j;
                                do
                                {
                                    if ((_case[i, k - 1] == 0)
                                        || (!fusion[i, k - 1] && (_case[i, k - 1] == _case[i, j])))
                                    {
                                        liberte = k - 1;
                                    }
                                    k -= 1;
                                } while ((k > 0) && (_case[i, k] == 0));
                                if (liberte != j)
                                {
                                    if (_case[i, liberte] == 0)
                                    {
                                        _case[i, liberte] = _case[i, j];
                                    }
                                    else
                                    {
                                        _case[i, liberte] *= 2;
                                        score += _case[i, liberte];
                                        fusion[i, liberte] = true;
                                    }
                                    _case[i, j] = 0;
                                    caseDeplacee = true;
                                    Logs.Debug("Déplacement vers le bas");
                                }
                            }
                        }
                    }

                    return (caseDeplacee, score);

                    return (caseDeplacee, score);
                case Sens.Autre:
                    return (caseDeplacee, score);
            }
            return (caseDeplacee, score);
        }


        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            log4net.GlobalContext.Properties["fichierLog"] = $"C:\\Users\\{Environment.UserName}\\Appdata\\Local\\Temp\\2048/log";
            log4net.Config.XmlConfigurator.Configure();
            Logs.Debug("Fermeture ?");
            e.Cancel = MessageBox.Show(String.Format("Fermeture de l'application demandée pour {0}. Voulez-vous quitter ?", e.CloseReason), "Fermeture...", MessageBoxButtons.YesNo) == DialogResult.No;
            Logs.Debug("Fermeture en cours");
        }
    }
}
