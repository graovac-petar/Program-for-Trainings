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
            this.msAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdministrator
            // 
            this.msAdministrator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdministrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programTreningaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem,
            this.grupaToolStripMenuItem});
            this.msAdministrator.Location = new System.Drawing.Point(0, 0);
            this.msAdministrator.Name = "msAdministrator";
            this.msAdministrator.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msAdministrator.Size = new System.Drawing.Size(963, 24);
            this.msAdministrator.TabIndex = 0;
            this.msAdministrator.Text = "menuStrip1";
            // 
            // programTreningaToolStripMenuItem
            // 
            this.programTreningaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem1,
            this.izmeniToolStripMenuItem1});
            this.programTreningaToolStripMenuItem.Name = "programTreningaToolStripMenuItem";
            this.programTreningaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.programTreningaToolStripMenuItem.Text = "Program Treninga";
            // 
            // kreirajToolStripMenuItem1
            // 
            this.kreirajToolStripMenuItem1.Name = "kreirajToolStripMenuItem1";
            this.kreirajToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kreirajToolStripMenuItem1.Text = "Kreiraj";
            // 
            // izmeniToolStripMenuItem1
            // 
            this.izmeniToolStripMenuItem1.Name = "izmeniToolStripMenuItem1";
            this.izmeniToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.izmeniToolStripMenuItem1.Text = "Izmeni";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // grupaToolStripMenuItem
            // 
            this.grupaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krairajToolStripMenuItem,
            this.izmeniToolStripMenuItem});
            this.grupaToolStripMenuItem.Name = "grupaToolStripMenuItem";
            this.grupaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.grupaToolStripMenuItem.Text = "Grupa";
            // 
            // krairajToolStripMenuItem
            // 
            this.krairajToolStripMenuItem.Name = "krairajToolStripMenuItem";
            this.krairajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krairajToolStripMenuItem.Text = "Krairaj";
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
            // 
            // pnlGlavna
            // 
            this.pnlGlavna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavna.Location = new System.Drawing.Point(0, 24);
            this.pnlGlavna.Name = "pnlGlavna";
            this.pnlGlavna.Size = new System.Drawing.Size(963, 710);
            this.pnlGlavna.TabIndex = 1;
            // 
            // FrmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 734);
            this.Controls.Add(this.pnlGlavna);
            this.Controls.Add(this.msAdministrator);
            this.MainMenuStrip = this.msAdministrator;
            this.Name = "FrmAdministrator";
            this.Text = "FrmAdministrator";
            this.msAdministrator.ResumeLayout(false);
            this.msAdministrator.PerformLayout();
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
    }
}