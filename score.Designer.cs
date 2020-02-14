namespace tp2048
{
    partial class score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataScores = new System.Windows.Forms.DataGridView();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataScores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataScores
            // 
            this.DataScores.AllowUserToAddRows = false;
            this.DataScores.AllowUserToDeleteRows = false;
            this.DataScores.AllowUserToResizeRows = false;
            this.DataScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.points,
            this.pseudo,
            this.instant});
            this.DataScores.Location = new System.Drawing.Point(12, 27);
            this.DataScores.Name = "DataScores";
            this.DataScores.ReadOnly = true;
            this.DataScores.Size = new System.Drawing.Size(440, 268);
            this.DataScores.TabIndex = 0;
            // 
            // points
            // 
            this.points.HeaderText = "points";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            // 
            // pseudo
            // 
            this.pseudo.HeaderText = "pseudo";
            this.pseudo.Name = "pseudo";
            this.pseudo.ReadOnly = true;
            // 
            // instant
            // 
            this.instant.HeaderText = "instant";
            this.instant.Name = "instant";
            this.instant.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 307);
            this.Controls.Add(this.DataScores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "score";
            this.Text = "Le Panthéon des Vainqueurs";
            this.Load += new System.EventHandler(this.score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataScores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn instant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}