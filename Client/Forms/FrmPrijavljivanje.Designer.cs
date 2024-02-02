using System.Windows.Forms;

namespace Client.Forms
{
    partial class FrmPrijavljivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijavljivanje));
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblPrijavljivanje = new System.Windows.Forms.Label();
            this.lblGreskaEmail = new System.Windows.Forms.Label();
            this.lblGreskaSifra = new System.Windows.Forms.Label();
            this.lblNemateNalog = new System.Windows.Forms.Label();
            this.lblRegistrujSe = new System.Windows.Forms.Label();
            this.ckbAdmin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnPrijaviSe.Location = new System.Drawing.Point(212, 325);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(181, 60);
            this.btnPrijaviSe.TabIndex = 0;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(158, 156);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(235, 33);
            this.txtKorisnickoIme.TabIndex = 1;
            // 
            // txtSifra
            // 
            this.txtSifra.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtSifra.Location = new System.Drawing.Point(158, 250);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(235, 33);
            this.txtSifra.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(42, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 35);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblSifra.ForeColor = System.Drawing.Color.Black;
            this.lblSifra.Location = new System.Drawing.Point(42, 248);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(75, 35);
            this.lblSifra.TabIndex = 4;
            this.lblSifra.Text = "Sifra";
            // 
            // lblPrijavljivanje
            // 
            this.lblPrijavljivanje.AutoSize = true;
            this.lblPrijavljivanje.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavljivanje.Location = new System.Drawing.Point(149, 41);
            this.lblPrijavljivanje.Name = "lblPrijavljivanje";
            this.lblPrijavljivanje.Size = new System.Drawing.Size(120, 58);
            this.lblPrijavljivanje.TabIndex = 5;
            this.lblPrijavljivanje.Text = "Log in";
            // 
            // lblGreskaEmail
            // 
            this.lblGreskaEmail.AutoSize = true;
            this.lblGreskaEmail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreskaEmail.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaEmail.Location = new System.Drawing.Point(155, 192);
            this.lblGreskaEmail.Name = "lblGreskaEmail";
            this.lblGreskaEmail.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaEmail.TabIndex = 6;
            this.lblGreskaEmail.Text = "Tekst";
            // 
            // lblGreskaSifra
            // 
            this.lblGreskaSifra.AutoSize = true;
            this.lblGreskaSifra.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaSifra.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaSifra.Location = new System.Drawing.Point(155, 286);
            this.lblGreskaSifra.Name = "lblGreskaSifra";
            this.lblGreskaSifra.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaSifra.TabIndex = 7;
            this.lblGreskaSifra.Text = "Tekst";
            // 
            // lblNemateNalog
            // 
            this.lblNemateNalog.AutoSize = true;
            this.lblNemateNalog.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblNemateNalog.Location = new System.Drawing.Point(236, 393);
            this.lblNemateNalog.Name = "lblNemateNalog";
            this.lblNemateNalog.Size = new System.Drawing.Size(135, 23);
            this.lblNemateNalog.TabIndex = 8;
            this.lblNemateNalog.Text = "Nemate nalog?";
            // 
            // lblRegistrujSe
            // 
            this.lblRegistrujSe.AutoSize = true;
            this.lblRegistrujSe.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrujSe.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegistrujSe.Location = new System.Drawing.Point(217, 416);
            this.lblRegistrujSe.Name = "lblRegistrujSe";
            this.lblRegistrujSe.Size = new System.Drawing.Size(176, 25);
            this.lblRegistrujSe.TabIndex = 9;
            this.lblRegistrujSe.Text = "Registruj se ovde";
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.ckbAdmin.Location = new System.Drawing.Point(159, 339);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(15, 14);
            this.ckbAdmin.TabIndex = 10;
            this.ckbAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(409, -75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 603);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin";
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(973, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckbAdmin);
            this.Controls.Add(this.lblRegistrujSe);
            this.Controls.Add(this.lblNemateNalog);
            this.Controls.Add(this.lblGreskaSifra);
            this.Controls.Add(this.lblGreskaEmail);
            this.Controls.Add(this.lblPrijavljivanje);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijaviSe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrijavljivanje";
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmPrijavljivanje_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSifra;
        private Label lblPrijavljivanje;
        private Label lblGreskaEmail;
        private Label lblGreskaSifra;
        private Label lblNemateNalog;
        private Label lblRegistrujSe;
        private CheckBox ckbAdmin;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;

        public Button BtnPrijaviSe { get => btnPrijaviSe; set => btnPrijaviSe = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblSifra { get => lblSifra; set => lblSifra = value; }
        public Label LblPrijavljivanje { get => lblPrijavljivanje; set => lblPrijavljivanje = value; }
        public Label LblGreskaEmail { get => lblGreskaEmail; set => lblGreskaEmail = value; }
        public Label LblGreskaSifra { get => lblGreskaSifra; set => lblGreskaSifra = value; }
        public Label LblNemateNalog { get => lblNemateNalog; set => lblNemateNalog = value; }
        public Label LblRegistrujSe { get => lblRegistrujSe; set => lblRegistrujSe = value; }
        public CheckBox CkbAdmin { get => ckbAdmin; set => ckbAdmin = value; }
    }
}