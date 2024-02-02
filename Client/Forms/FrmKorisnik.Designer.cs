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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlGlavna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift", 18.75F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaProgramaTreningaToolStripMenuItem,
            this.prijavaNaProgramTreningaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pretragaProgramaTreningaToolStripMenuItem
            // 
            this.pretragaProgramaTreningaToolStripMenuItem.Name = "pretragaProgramaTreningaToolStripMenuItem";
            this.pretragaProgramaTreningaToolStripMenuItem.Size = new System.Drawing.Size(373, 34);
            this.pretragaProgramaTreningaToolStripMenuItem.Text = "Prijave se na program treninga";
            // 
            // prijavaNaProgramTreningaToolStripMenuItem
            // 
            this.prijavaNaProgramTreningaToolStripMenuItem.Name = "prijavaNaProgramTreningaToolStripMenuItem";
            this.prijavaNaProgramTreningaToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.prijavaNaProgramTreningaToolStripMenuItem.Text = "Moje Prijave";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Controls.Add(this.pictureBox1);
            this.pnlGlavna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 38);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(1143, 803);
            this.pnlGlavna.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Client.Properties.Resources.everything_you_need_know_about_fitness_1440x810;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 803);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1143, 841);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmKorisnik";
            this.Text = "FrmKorisnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGlavna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretragaProgramaTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaNaProgramTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavna;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}