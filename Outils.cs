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
                    couleurFond = Color.FromArgb(0x7A,0xFF,0xF6);
                    break;
                case 4:
                    couleurFond = Color.FromArgb(0x48,0xE8,0xA7);
                    break;
                case 8:
                    couleurFond = Color.FromArgb(0x5C,0xFF,0x84);
                    break;
                case 16:
                    couleurFond = Color.FromArgb(0x5A,0xE8,0x48);
                    break;
                case 32:
                    couleurFond = Color.FromArgb(0xAD,0xFF,0x4F);
                    break;
                case 64:
                    couleurFond = Color.FromArgb(0xEB,0xDA,0x38);
                    break;
                case 128:
                    couleurFond = Color.FromArgb(0xFF,0xC2,0x40);
                    break;
                case 256:
                    couleurFond = Color.FromArgb(0xEB,0x99,0x63);
                    break;
                case 512:
                    couleurFond = Color.FromArgb(0xFF, 0x82,0x78);
                    break;
                case 1024:
                    couleurFond = Color.FromArgb(0xFF,0x45,0x5A);
                    break;
                case 2048:
                    couleurFond = Color.FromArgb(0xFF, 0x45, 0x5A);
                    break;
            }
            var couleur = new Dictionary<string, Color>
            {
                ["fonte"] = couleurFonte,
                ["fond"] = couleurFond
            };
            return couleur;
        }

        public static(int,int,int) aleaCase(int[,] plateau)
        {
            const float PROBA2 = 0.9F;
            int x;
            int y;
            int v = 2;
            Random rnd = new Random();

            do
            {
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
            } while (plateau[x, y] != 0);
            if(rnd.NextDouble()>=PROBA2)
            {
                v = 4;
            }
            return (x, y, v);
        }
        public static string SaveStr(int[,] plateau)
        {
            string result = "";
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int pow = (plateau[i, j] == 0) ? 0 : (int)Math.Log(plateau[i, j], 2);
                    result += pow.ToString("X");
                }
                if (i != 3) { result += ","; }
            }
            return result;
        }

        public static int[,] LoadStr(string hex)
        {
            int[,] resultat = new int[4, 4];
            int i = 0;
            foreach (string colonne in hex.Split(','))
            {
                for (int j = 0; j<=3; j++)
                {
                    int value = int.Parse(colonne[j].ToString(), System.Globalization.NumberStyles.HexNumber);
                    resultat[i, j] = (value == 0) ? 0 : (int)Math.Pow(2, value);
                }
                i++;
            }
            return resultat;
        }
    }
}

