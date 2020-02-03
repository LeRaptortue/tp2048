namespace tp2048
{
    partial class Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NouveauJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelEtat = new System.Windows.Forms.ToolStripStatusLabel();
            this.Grille = new System.Windows.Forms.TableLayoutPanel();
            this.Case33 = new System.Windows.Forms.Label();
            this.Case23 = new System.Windows.Forms.Label();
            this.Case13 = new System.Windows.Forms.Label();
            this.Case03 = new System.Windows.Forms.Label();
            this.Case32 = new System.Windows.Forms.Label();
            this.Case22 = new System.Windows.Forms.Label();
            this.Case12 = new System.Windows.Forms.Label();
            this.Case02 = new System.Windows.Forms.Label();
            this.Case31 = new System.Windows.Forms.Label();
            this.Case21 = new System.Windows.Forms.Label();
            this.Case11 = new System.Windows.Forms.Label();
            this.Case01 = new System.Windows.Forms.Label();
            this.Case30 = new System.Windows.Forms.Label();
            this.Case20 = new System.Windows.Forms.Label();
            this.Case10 = new System.Windows.Forms.Label();
            this.Case00 = new System.Windows.Forms.Label();
            this.TexteScore = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.TexteMouvement = new System.Windows.Forms.Label();
            this.LabelMouvement = new System.Windows.Forms.Label();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposDu2048ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Grille.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouveauJeu,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NouveauJeu
            // 
            this.NouveauJeu.Name = "NouveauJeu";
            this.NouveauJeu.Size = new System.Drawing.Size(67, 20);
            this.NouveauJeu.Text = "&Nouveau";
            this.NouveauJeu.Click += new System.EventHandler(this.NouveauJeu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelEtat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelEtat
            // 
            this.LabelEtat.Name = "LabelEtat";
            this.LabelEtat.Size = new System.Drawing.Size(27, 17);
            this.LabelEtat.Text = "Etat";
            this.LabelEtat.Click += new System.EventHandler(this.LabelEtat_Click);
            // 
            // Grille
            // 
            this.Grille.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Grille.ColumnCount = 4;
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.Controls.Add(this.Case33, 3, 3);
            this.Grille.Controls.Add(this.Case23, 2, 3);
            this.Grille.Controls.Add(this.Case13, 1, 3);
            this.Grille.Controls.Add(this.Case03, 0, 3);
            this.Grille.Controls.Add(this.Case32, 3, 2);
            this.Grille.Controls.Add(this.Case22, 2, 2);
            this.Grille.Controls.Add(this.Case12, 1, 2);
            this.Grille.Controls.Add(this.Case02, 0, 2);
            this.Grille.Controls.Add(this.Case31, 3, 1);
            this.Grille.Controls.Add(this.Case21, 2, 1);
            this.Grille.Controls.Add(this.Case11, 1, 1);
            this.Grille.Controls.Add(this.Case01, 0, 1);
            this.Grille.Controls.Add(this.Case30, 3, 0);
            this.Grille.Controls.Add(this.Case20, 2, 0);
            this.Grille.Controls.Add(this.Case10, 1, 0);
            this.Grille.Controls.Add(this.Case00, 0, 0);
            this.Grille.Location = new System.Drawing.Point(20, 54);
            this.Grille.Name = "Grille";
            this.Grille.RowCount = 4;
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Grille.Size = new System.Drawing.Size(300, 300);
            this.Grille.TabIndex = 2;
            // 
            // Case33
            // 
            this.Case33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case33.BackColor = System.Drawing.Color.LightGreen;
            this.Case33.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case33.Location = new System.Drawing.Point(227, 227);
            this.Case33.Margin = new System.Windows.Forms.Padding(2);
            this.Case33.Name = "Case33";
            this.Case33.Size = new System.Drawing.Size(71, 71);
            this.Case33.TabIndex = 15;
            this.Case33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case23
            // 
            this.Case23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case23.BackColor = System.Drawing.Color.LightGreen;
            this.Case23.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case23.Location = new System.Drawing.Point(152, 227);
            this.Case23.Margin = new System.Windows.Forms.Padding(2);
            this.Case23.Name = "Case23";
            this.Case23.Size = new System.Drawing.Size(71, 71);
            this.Case23.TabIndex = 14;
            this.Case23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case13
            // 
            this.Case13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case13.BackColor = System.Drawing.Color.LightGreen;
            this.Case13.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case13.Location = new System.Drawing.Point(77, 227);
            this.Case13.Margin = new System.Windows.Forms.Padding(2);
            this.Case13.Name = "Case13";
            this.Case13.Size = new System.Drawing.Size(71, 71);
            this.Case13.TabIndex = 13;
            this.Case13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case03
            // 
            this.Case03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case03.BackColor = System.Drawing.Color.LightGreen;
            this.Case03.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case03.Location = new System.Drawing.Point(2, 227);
            this.Case03.Margin = new System.Windows.Forms.Padding(2);
            this.Case03.Name = "Case03";
            this.Case03.Size = new System.Drawing.Size(71, 71);
            this.Case03.TabIndex = 12;
            this.Case03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case32
            // 
            this.Case32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case32.BackColor = System.Drawing.Color.LightGreen;
            this.Case32.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case32.Location = new System.Drawing.Point(227, 152);
            this.Case32.Margin = new System.Windows.Forms.Padding(2);
            this.Case32.Name = "Case32";
            this.Case32.Size = new System.Drawing.Size(71, 71);
            this.Case32.TabIndex = 11;
            this.Case32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case22
            // 
            this.Case22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case22.BackColor = System.Drawing.Color.LightGreen;
            this.Case22.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case22.Location = new System.Drawing.Point(152, 152);
            this.Case22.Margin = new System.Windows.Forms.Padding(2);
            this.Case22.Name = "Case22";
            this.Case22.Size = new System.Drawing.Size(71, 71);
            this.Case22.TabIndex = 10;
            this.Case22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case12
            // 
            this.Case12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case12.BackColor = System.Drawing.Color.LightGreen;
            this.Case12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case12.Location = new System.Drawing.Point(77, 152);
            this.Case12.Margin = new System.Windows.Forms.Padding(2);
            this.Case12.Name = "Case12";
            this.Case12.Size = new System.Drawing.Size(71, 71);
            this.Case12.TabIndex = 9;
            this.Case12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case02
            // 
            this.Case02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case02.BackColor = System.Drawing.Color.LightGreen;
            this.Case02.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case02.Location = new System.Drawing.Point(2, 152);
            this.Case02.Margin = new System.Windows.Forms.Padding(2);
            this.Case02.Name = "Case02";
            this.Case02.Size = new System.Drawing.Size(71, 71);
            this.Case02.TabIndex = 8;
            this.Case02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case31
            // 
            this.Case31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case31.BackColor = System.Drawing.Color.LightGreen;
            this.Case31.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case31.Location = new System.Drawing.Point(227, 77);
            this.Case31.Margin = new System.Windows.Forms.Padding(2);
            this.Case31.Name = "Case31";
            this.Case31.Size = new System.Drawing.Size(71, 71);
            this.Case31.TabIndex = 7;
            this.Case31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case21
            // 
            this.Case21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case21.BackColor = System.Drawing.Color.LightGreen;
            this.Case21.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case21.Location = new System.Drawing.Point(152, 77);
            this.Case21.Margin = new System.Windows.Forms.Padding(2);
            this.Case21.Name = "Case21";
            this.Case21.Size = new System.Drawing.Size(71, 71);
            this.Case21.TabIndex = 6;
            this.Case21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case11
            // 
            this.Case11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case11.BackColor = System.Drawing.Color.LightGreen;
            this.Case11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case11.Location = new System.Drawing.Point(77, 77);
            this.Case11.Margin = new System.Windows.Forms.Padding(2);
            this.Case11.Name = "Case11";
            this.Case11.Size = new System.Drawing.Size(71, 71);
            this.Case11.TabIndex = 5;
            this.Case11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case01
            // 
            this.Case01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case01.BackColor = System.Drawing.Color.LightGreen;
            this.Case01.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case01.Location = new System.Drawing.Point(2, 77);
            this.Case01.Margin = new System.Windows.Forms.Padding(2);
            this.Case01.Name = "Case01";
            this.Case01.Size = new System.Drawing.Size(71, 71);
            this.Case01.TabIndex = 4;
            this.Case01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case30
            // 
            this.Case30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case30.BackColor = System.Drawing.Color.LightGreen;
            this.Case30.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case30.Location = new System.Drawing.Point(227, 2);
            this.Case30.Margin = new System.Windows.Forms.Padding(2);
            this.Case30.Name = "Case30";
            this.Case30.Size = new System.Drawing.Size(71, 71);
            this.Case30.TabIndex = 3;
            this.Case30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case20
            // 
            this.Case20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case20.BackColor = System.Drawing.Color.LightGreen;
            this.Case20.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case20.Location = new System.Drawing.Point(152, 2);
            this.Case20.Margin = new System.Windows.Forms.Padding(2);
            this.Case20.Name = "Case20";
            this.Case20.Size = new System.Drawing.Size(71, 71);
            this.Case20.TabIndex = 2;
            this.Case20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case10
            // 
            this.Case10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case10.BackColor = System.Drawing.Color.LightGreen;
            this.Case10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case10.Location = new System.Drawing.Point(77, 2);
            this.Case10.Margin = new System.Windows.Forms.Padding(2);
            this.Case10.Name = "Case10";
            this.Case10.Size = new System.Drawing.Size(71, 71);
            this.Case10.TabIndex = 1;
            this.Case10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Case00
            // 
            this.Case00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Case00.BackColor = System.Drawing.Color.LightGreen;
            this.Case00.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case00.Location = new System.Drawing.Point(2, 2);
            this.Case00.Margin = new System.Windows.Forms.Padding(2);
            this.Case00.Name = "Case00";
            this.Case00.Size = new System.Drawing.Size(71, 71);
            this.Case00.TabIndex = 0;
            this.Case00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TexteScore
            // 
            this.TexteScore.AutoSize = true;
            this.TexteScore.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexteScore.Location = new System.Drawing.Point(20, 28);
            this.TexteScore.Name = "TexteScore";
            this.TexteScore.Size = new System.Drawing.Size(64, 18);
            this.TexteScore.TabIndex = 3;
            this.TexteScore.Text = "Score :";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(90, 28);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(0, 18);
            this.LabelScore.TabIndex = 4;
            // 
            // TexteMouvement
            // 
            this.TexteMouvement.AutoSize = true;
            this.TexteMouvement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexteMouvement.Location = new System.Drawing.Point(139, 28);
            this.TexteMouvement.Name = "TexteMouvement";
            this.TexteMouvement.Size = new System.Drawing.Size(104, 18);
            this.TexteMouvement.TabIndex = 5;
            this.TexteMouvement.Text = "Mouvements :";
            // 
            // LabelMouvement
            // 
            this.LabelMouvement.AutoSize = true;
            this.LabelMouvement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMouvement.Location = new System.Drawing.Point(249, 28);
            this.LabelMouvement.Name = "LabelMouvement";
            this.LabelMouvement.Size = new System.Drawing.Size(0, 18);
            this.LabelMouvement.TabIndex = 6;
            this.LabelMouvement.Click += new System.EventHandler(this.label1_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLaideToolStripMenuItem,
            this.àProposDu2048ToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // afficherLaideToolStripMenuItem
            // 
            this.afficherLaideToolStripMenuItem.Name = "afficherLaideToolStripMenuItem";
            this.afficherLaideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherLaideToolStripMenuItem.Text = "Afficher l\'aide";
            // 
            // àProposDu2048ToolStripMenuItem
            // 
            this.àProposDu2048ToolStripMenuItem.Name = "àProposDu2048ToolStripMenuItem";
            this.àProposDu2048ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.àProposDu2048ToolStripMenuItem.Text = "À propos du 2048";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 392);
            this.Controls.Add(this.LabelMouvement);
            this.Controls.Add(this.TexteMouvement);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.TexteScore);
            this.Controls.Add(this.Grille);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 430);
            this.Name = "Jeu";
            this.Text = "2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jeu_FormClosing);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jeu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Grille.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NouveauJeu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelEtat;
        private System.Windows.Forms.TableLayoutPanel Grille;
        private System.Windows.Forms.Label Case33;
        private System.Windows.Forms.Label Case23;
        private System.Windows.Forms.Label Case13;
        private System.Windows.Forms.Label Case03;
        private System.Windows.Forms.Label Case32;
        private System.Windows.Forms.Label Case22;
        private System.Windows.Forms.Label Case12;
        private System.Windows.Forms.Label Case02;
        private System.Windows.Forms.Label Case31;
        private System.Windows.Forms.Label Case21;
        private System.Windows.Forms.Label Case11;
        private System.Windows.Forms.Label Case01;
        private System.Windows.Forms.Label Case30;
        private System.Windows.Forms.Label Case20;
        private System.Windows.Forms.Label Case10;
        private System.Windows.Forms.Label Case00;
        private System.Windows.Forms.Label TexteScore;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label TexteMouvement;
        private System.Windows.Forms.Label LabelMouvement;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLaideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposDu2048ToolStripMenuItem;
    }
}

