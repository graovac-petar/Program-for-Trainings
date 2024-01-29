namespace Client.Forms
{
    partial class FrmKorisnik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pretragaProgramaTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavaNaProgramTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaProgramaTreningaToolStripMenuItem,
            this.prijavaNaProgramTreningaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pretragaProgramaTreningaToolStripMenuItem
            // 
            this.pretragaProgramaTreningaToolStripMenuItem.Name = "pretragaProgramaTreningaToolStripMenuItem";
            this.pretragaProgramaTreningaToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.pretragaProgramaTreningaToolStripMenuItem.Text = "Prijave se na program treninga";
            // 
            // prijavaNaProgramTreningaToolStripMenuItem
            // 
            this.prijavaNaProgramTreningaToolStripMenuItem.Name = "prijavaNaProgramTreningaToolStripMenuItem";
            this.prijavaNaProgramTreningaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.prijavaNaProgramTreningaToolStripMenuItem.Text = "Moje Prijave";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 24);
            this.pnlGlavna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(1199, 977);
            this.pnlGlavna.TabIndex = 1;
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 1001);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKorisnik";
            this.Text = "FrmKorisnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretragaProgramaTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNaProgramTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavna;
    }
}