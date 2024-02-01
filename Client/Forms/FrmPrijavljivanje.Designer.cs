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
            this.SuspendLayout();
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(310, 282);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(181, 60);
            this.btnPrijaviSe.TabIndex = 0;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(350, 165);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnickoIme.TabIndex = 1;
            this.txtKorisnickoIme.Text = "z@gmail.com";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(350, 215);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 2;
            this.txtSifra.Text = "3";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(293, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(293, 218);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 4;
            this.lblSifra.Text = "Sifra";
            // 
            // lblPrijavljivanje
            // 
            this.lblPrijavljivanje.AutoSize = true;
            this.lblPrijavljivanje.Location = new System.Drawing.Point(367, 78);
            this.lblPrijavljivanje.Name = "lblPrijavljivanje";
            this.lblPrijavljivanje.Size = new System.Drawing.Size(36, 13);
            this.lblPrijavljivanje.TabIndex = 5;
            this.lblPrijavljivanje.Text = "Log in";
            // 
            // lblGreskaEmail
            // 
            this.lblGreskaEmail.AutoSize = true;
            this.lblGreskaEmail.Location = new System.Drawing.Point(347, 188);
            this.lblGreskaEmail.Name = "lblGreskaEmail";
            this.lblGreskaEmail.Size = new System.Drawing.Size(34, 13);
            this.lblGreskaEmail.TabIndex = 6;
            this.lblGreskaEmail.Text = "Tekst";
            // 
            // lblGreskaSifra
            // 
            this.lblGreskaSifra.AutoSize = true;
            this.lblGreskaSifra.Location = new System.Drawing.Point(347, 238);
            this.lblGreskaSifra.Name = "lblGreskaSifra";
            this.lblGreskaSifra.Size = new System.Drawing.Size(34, 13);
            this.lblGreskaSifra.TabIndex = 7;
            this.lblGreskaSifra.Text = "Tekst";
            // 
            // lblNemateNalog
            // 
            this.lblNemateNalog.AutoSize = true;
            this.lblNemateNalog.Location = new System.Drawing.Point(371, 356);
            this.lblNemateNalog.Name = "lblNemateNalog";
            this.lblNemateNalog.Size = new System.Drawing.Size(79, 13);
            this.lblNemateNalog.TabIndex = 8;
            this.lblNemateNalog.Text = "Nemate nalog?";
            // 
            // lblRegistrujSe
            // 
            this.lblRegistrujSe.AutoSize = true;
            this.lblRegistrujSe.Location = new System.Drawing.Point(367, 379);
            this.lblRegistrujSe.Name = "lblRegistrujSe";
            this.lblRegistrujSe.Size = new System.Drawing.Size(89, 13);
            this.lblRegistrujSe.TabIndex = 9;
            this.lblRegistrujSe.Text = "Registruj se ovde";
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Checked = true;
            this.ckbAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdmin.Location = new System.Drawing.Point(350, 259);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(55, 17);
            this.ckbAdmin.TabIndex = 10;
            this.ckbAdmin.Text = "Admin";
            this.ckbAdmin.UseVisualStyleBackColor = true;
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmPrijavljivanje";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrijavljivanje_Load);
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