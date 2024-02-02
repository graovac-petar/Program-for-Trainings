namespace Client.Forms
{
    partial class FrmAdministrator
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
            this.msAdministrator = new System.Windows.Forms.MenuStrip();
            this.programTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krairajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavna = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msAdministrator.SuspendLayout();
            this.pnlGlavna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msAdministrator
            // 
            this.msAdministrator.Font = new System.Drawing.Font("Bahnschrift", 18.75F);
            this.msAdministrator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programTreningaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem,
            this.grupaToolStripMenuItem});
            this.msAdministrator.Location = new System.Drawing.Point(0, 0);
            this.msAdministrator.Name = "msAdministrator";
            this.msAdministrator.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msAdministrator.Size = new System.Drawing.Size(1143, 38);
            this.msAdministrator.TabIndex = 0;
            this.msAdministrator.Text = "menuStrip1";
            // 
            // programTreningaToolStripMenuItem
            // 
            this.programTreningaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem1,
            this.izmeniToolStripMenuItem1});
            this.programTreningaToolStripMenuItem.Name = "programTreningaToolStripMenuItem";
            this.programTreningaToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.programTreningaToolStripMenuItem.Text = "Program Treninga";
            // 
            // kreirajToolStripMenuItem1
            // 
            this.kreirajToolStripMenuItem1.Name = "kreirajToolStripMenuItem1";
            this.kreirajToolStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.kreirajToolStripMenuItem1.Text = "Kreiraj";
            // 
            // izmeniToolStripMenuItem1
            // 
            this.izmeniToolStripMenuItem1.Name = "izmeniToolStripMenuItem1";
            this.izmeniToolStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.izmeniToolStripMenuItem1.Text = "Izmeni";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // grupaToolStripMenuItem
            // 
            this.grupaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krairajToolStripMenuItem,
            this.izmeniToolStripMenuItem});
            this.grupaToolStripMenuItem.Name = "grupaToolStripMenuItem";
            this.grupaToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            this.grupaToolStripMenuItem.Text = "Grupa";
            // 
            // krairajToolStripMenuItem
            // 
            this.krairajToolStripMenuItem.Name = "krairajToolStripMenuItem";
            this.krairajToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.krairajToolStripMenuItem.Text = "Kreiraj";
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
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
            // FrmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1143, 841);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.msAdministrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.msAdministrator;
            this.MaximizeBox = false;
            this.Name = "FrmAdministrator";
            this.Text = "FrmAdministrator";
            this.msAdministrator.ResumeLayout(false);
            this.msAdministrator.PerformLayout();
            this.pnlGlavna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdministrator;
        private System.Windows.Forms.ToolStripMenuItem programTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavna;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grupaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krairajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}