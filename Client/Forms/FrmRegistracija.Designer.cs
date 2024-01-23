using System.Windows.Forms;

namespace Client.Forms
{
    partial class FrmRegistracija
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
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblGreskaSifra = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblGreskaDatum = new System.Windows.Forms.Label();
            this.lblGreskaPrezime = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGreskaEmail = new System.Windows.Forms.Label();
            this.lblGreskaKontakt = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblGreskaIme = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(334, 65);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(62, 13);
            this.lblRegistracija.TabIndex = 0;
            this.lblRegistracija.Text = "Registracija";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(216, 125);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblGreskaSifra
            // 
            this.lblGreskaSifra.AutoSize = true;
            this.lblGreskaSifra.Location = new System.Drawing.Point(328, 461);
            this.lblGreskaSifra.Name = "lblGreskaSifra";
            this.lblGreskaSifra.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaSifra.TabIndex = 3;
            this.lblGreskaSifra.Text = "label4";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(212, 261);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(83, 13);
            this.lblDatumRodjenja.TabIndex = 5;
            this.lblDatumRodjenja.Text = "Datum Rodjenja";
            // 
            // lblGreskaDatum
            // 
            this.lblGreskaDatum.AutoSize = true;
            this.lblGreskaDatum.Location = new System.Drawing.Point(334, 284);
            this.lblGreskaDatum.Name = "lblGreskaDatum";
            this.lblGreskaDatum.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaDatum.TabIndex = 6;
            this.lblGreskaDatum.Text = "label7";
            // 
            // lblGreskaPrezime
            // 
            this.lblGreskaPrezime.AutoSize = true;
            this.lblGreskaPrezime.Location = new System.Drawing.Point(334, 226);
            this.lblGreskaPrezime.Name = "lblGreskaPrezime";
            this.lblGreskaPrezime.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaPrezime.TabIndex = 7;
            this.lblGreskaPrezime.Text = "label8";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(216, 203);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblGreskaEmail
            // 
            this.lblGreskaEmail.AutoSize = true;
            this.lblGreskaEmail.Location = new System.Drawing.Point(328, 407);
            this.lblGreskaEmail.Name = "lblGreskaEmail";
            this.lblGreskaEmail.Size = new System.Drawing.Size(41, 13);
            this.lblGreskaEmail.TabIndex = 9;
            this.lblGreskaEmail.Text = "label10";
            // 
            // lblGreskaKontakt
            // 
            this.lblGreskaKontakt.AutoSize = true;
            this.lblGreskaKontakt.Location = new System.Drawing.Point(328, 349);
            this.lblGreskaKontakt.Name = "lblGreskaKontakt";
            this.lblGreskaKontakt.Size = new System.Drawing.Size(41, 13);
            this.lblGreskaKontakt.TabIndex = 10;
            this.lblGreskaKontakt.Text = "label11";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(216, 438);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 11;
            this.lblSifra.Text = "Sifra";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(219, 384);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(216, 329);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(79, 13);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Kontakt telefon";
            // 
            // lblGreskaIme
            // 
            this.lblGreskaIme.AutoSize = true;
            this.lblGreskaIme.Location = new System.Drawing.Point(334, 150);
            this.lblGreskaIme.Name = "lblGreskaIme";
            this.lblGreskaIme.Size = new System.Drawing.Size(41, 13);
            this.lblGreskaIme.TabIndex = 14;
            this.lblGreskaIme.Text = "label15";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(259, 588);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(148, 57);
            this.btnRegistracija.TabIndex = 15;
            this.btnRegistracija.Text = "Registruj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(318, 127);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 16;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(318, 203);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 17;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(318, 326);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 20);
            this.txtKontakt.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 384);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(318, 438);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 21;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(318, 261);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(188, 20);
            this.dtpDatumRodjenja.TabIndex = 22;
            this.dtpDatumRodjenja.Value = new System.DateTime(2001, 10, 19, 0, 0, 0, 0);
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.lblGreskaIme);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblGreskaKontakt);
            this.Controls.Add(this.lblGreskaEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblGreskaPrezime);
            this.Controls.Add(this.lblGreskaDatum);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblGreskaSifra);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblRegistracija);
            this.Name = "FrmRegistracija";
            this.Text = "FrmRegistracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblGreskaSifra;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblGreskaDatum;
        private System.Windows.Forms.Label lblGreskaPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGreskaEmail;
        private System.Windows.Forms.Label lblGreskaKontakt;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblGreskaIme;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;

        public Label LblRegistracija { get => lblRegistracija; set => lblRegistracija = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblGreskaSifra { get => lblGreskaSifra; set => lblGreskaSifra = value; }
        public Label LblDatumRodjenja { get => lblDatumRodjenja; set => lblDatumRodjenja = value; }
        public Label LblGreskaDatum { get => lblGreskaDatum; set => lblGreskaDatum = value; }
        public Label LblGreskaPrezime { get => lblGreskaPrezime; set => lblGreskaPrezime = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblGreskaEmail { get => lblGreskaEmail; set => lblGreskaEmail = value; }
        public Label LblGreskaKontakt { get => lblGreskaKontakt; set => lblGreskaKontakt = value; }
        public Label LblSifra { get => lblSifra; set => lblSifra = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblTelefon { get => lblTelefon; set => lblTelefon = value; }
        public Label LblGreskaIme { get => lblGreskaIme; set => lblGreskaIme = value; }
        public Button BtnRegistracija { get => btnRegistracija; set => btnRegistracija = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtKontakt { get => txtKontakt; set => txtKontakt = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
        public DateTimePicker DtpDatumRodjenja { get => dtpDatumRodjenja; set => dtpDatumRodjenja = value; }
    }
}