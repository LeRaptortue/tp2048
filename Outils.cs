using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2048
{
    class Outils
    {
        public static Dictionary<string, Color> Couleurs(int valeur)
        {
            Color couleurFonte = Color.Black;
            Color couleurFond = SystemColors.ButtonFace;
            switch(valeur)
            {
                case 2:
                    couleurFond = Color.MediumSeaGreen;
                    break;
                case 4:
                    couleurFond = Color.SpringGreen;
                    break;
                case 8:
                    couleurFond = Color.SeaGreen;
                    break;
                case 16:
                    couleurFond = Color.ForestGreen;
                    break;
                case 32:
                    couleurFond = Color.Green;
                    break;
                case 64:
                    couleurFond = Color.DarkGreen;
                    break;
                case 128:
                    couleurFond = Color.DarkOliveGreen;
                    break;
                case 256:
                    couleurFond = Color.OliveDrab;
                    break;
                case 512:
                    couleurFond = Color.SpringGreen;
                    break;
                case 1024:
                    couleurFond = Color.Teal;
                    break;
                case 2048:
                    couleurFond = Color.MediumSpringGreen;
                    break;
            }
            var couleur = new Dictionary<string, System.Drawing.Color>
            {
                ["fonte"] = couleurFonte,
                ["fond"] = couleurFond
            };
            return couleur;
        }
    }
}
