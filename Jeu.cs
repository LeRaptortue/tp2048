﻿using System;
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

        private void afficherLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}