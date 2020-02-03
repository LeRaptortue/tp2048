using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Gestion des déplacements

namespace tp2048
{
    partial class Jeu
    {
        public enum Sens
        {
            Haut, Bas, Droite, Gauche, Autre
        }

        //Association fleche directionnelle au sens de déplacement
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

        //Calcul de la position des cases
        //'liberte' permet au case de se décaler au maximum si il n'y a pas de case pour l'en empêcher
        //'fusion' s'occupe de l'addition des cases de même valeur
        private (bool, int) Bouge(Sens s)
        {
            bool caseDeplacee = false;
            int score = 0;
            bool[,] fusion = new bool[4, 4];
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
                                        || (!fusion[k + 1, j] && (_case[k + 1, j] == _case[i, j])))
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
                                    if (_case[liberte, j] == 2048)
                                    {
                                        EventArgs args = new EventArgs();
                                        onFusion2048(args);
                                    }
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
                                    if (_case[liberte, j] == 2048)
                                    {
                                        EventArgs args = new EventArgs();
                                        onFusion2048(args);
                                    }
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
                                    if ((_case[i, k + 1] == 0)
                                        || (!fusion[i, k + 1] && (_case[i, k + 1] == _case[i, j])))
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
                                    if (_case[i, liberte] == 2048)
                                    {
                                        EventArgs args = new EventArgs();
                                        onFusion2048(args);
                                    }
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
                                    if (_case[i, liberte] == 2048)
                                    {
                                        EventArgs args = new EventArgs();
                                        onFusion2048(args);
                                    }
                                }
                            }
                        }
                    }
                    return (caseDeplacee, score);
                case Sens.Autre:
                    return (caseDeplacee, score);
            }
            return (caseDeplacee, score);
        }
    }
}
