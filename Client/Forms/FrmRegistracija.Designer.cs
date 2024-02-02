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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracija.Location = new System.Drawing.Point(251, 67);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(217, 58);
            this.lblRegistracija.TabIndex = 0;
            this.lblRegistracija.Text = "Registracija";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblIme.Location = new System.Drawing.Point(31, 167);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(64, 35);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblGreskaSifra
            // 
            this.lblGreskaSifra.AutoSize = true;
            this.lblGreskaSifra.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaSifra.Location = new System.Drawing.Point(164, 534);
            this.lblGreskaSifra.Name = "lblGreskaSifra";
            this.lblGreskaSifra.Size = new System.Drawing.Size(55, 19);
            this.lblGreskaSifra.TabIndex = 3;
            this.lblGreskaSifra.Text = "label4";
            this.lblGreskaSifra.Visible = false;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblDatumRodjenja.Location = new System.Drawing.Point(31, 295);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(220, 35);
            this.lblDatumRodjenja.TabIndex = 5;
            this.lblDatumRodjenja.Text = "Datum Rodjenja";
            // 
            // lblGreskaDatum
            // 
            this.lblGreskaDatum.AutoSize = true;
            this.lblGreskaDatum.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaDatum.Location = new System.Drawing.Point(257, 330);
            this.lblGreskaDatum.Name = "lblGreskaDatum";
            this.lblGreskaDatum.Size = new System.Drawing.Size(54, 19);
            this.lblGreskaDatum.TabIndex = 6;
            this.lblGreskaDatum.Text = "label7";
            this.lblGreskaDatum.Visible = false;
            // 
            // lblGreskaPrezime
            // 
            this.lblGreskaPrezime.AutoSize = true;
            this.lblGreskaPrezime.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaPrezime.Location = new System.Drawing.Point(177, 267);
            this.lblGreskaPrezime.Name = "lblGreskaPrezime";
            this.lblGreskaPrezime.Size = new System.Drawing.Size(55, 19);
            this.lblGreskaPrezime.TabIndex = 7;
            this.lblGreskaPrezime.Text = "label8";
            this.lblGreskaPrezime.Visible = false;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblPrezime.Location = new System.Drawing.Point(31, 231);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(122, 35);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblGreskaEmail
            // 
            this.lblGreskaEmail.AutoSize = true;
            this.lblGreskaEmail.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaEmail.Location = new System.Drawing.Point(164, 468);
            this.lblGreskaEmail.Name = "lblGreskaEmail";
            this.lblGreskaEmail.Size = new System.Drawing.Size(60, 19);
            this.lblGreskaEmail.TabIndex = 9;
            this.lblGreskaEmail.Text = "label10";
            this.lblGreskaEmail.Visible = false;
            // 
            // lblGreskaKontakt
            // 
            this.lblGreskaKontakt.AutoSize = true;
            this.lblGreskaKontakt.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaKontakt.Location = new System.Drawing.Point(245, 403);
            this.lblGreskaKontakt.Name = "lblGreskaKontakt";
            this.lblGreskaKontakt.Size = new System.Drawing.Size(56, 19);
            this.lblGreskaKontakt.TabIndex = 10;
            this.lblGreskaKontakt.Text = "label11";
            this.lblGreskaKontakt.Visible = false;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblSifra.Location = new System.Drawing.Point(31, 493);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(75, 35);
            this.lblSifra.TabIndex = 11;
            this.lblSifra.Text = "Sifra";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblEmail.Location = new System.Drawing.Point(31, 427);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 35);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblTelefon.Location = new System.Drawing.Point(31, 362);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(212, 35);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Kontakt telefon";
            // 
            // lblGreskaIme
            // 
            this.lblGreskaIme.AutoSize = true;
            this.lblGreskaIme.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaIme.Location = new System.Drawing.Point(108, 203);
            this.lblGreskaIme.Name = "lblGreskaIme";
            this.lblGreskaIme.Size = new System.Drawing.Size(60, 19);
            this.lblGreskaIme.TabIndex = 14;
            this.lblGreskaIme.Text = "label15";
            this.lblGreskaIme.Visible = false;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtIme.Location = new System.Drawing.Point(112, 167);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(510, 33);
            this.txtIme.TabIndex = 16;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtPrezime.Location = new System.Drawing.Point(181, 233);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(441, 33);
            this.txtPrezime.TabIndex = 17;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtKontakt.Location = new System.Drawing.Point(249, 367);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(373, 33);
            this.txtKontakt.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtEmail.Location = new System.Drawing.Point(168, 432);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 33);
            this.txtEmail.TabIndex = 20;
            // 
            // txtSifra
            // 
            this.txtSifra.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtSifra.Location = new System.Drawing.Point(168, 498);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(454, 33);
            this.txtSifra.TabIndex = 21;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(249, 294);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(373, 33);
            this.dtpDatumRodjenja.TabIndex = 22;
            this.dtpDatumRodjenja.Value = new System.DateTime(2001, 10, 19, 0, 0, 0, 0);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegistracija.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnRegistracija.Location = new System.Drawing.Point(287, 560);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(181, 60);
            this.btnRegistracija.TabIndex = 23;
            this.btnRegistracija.Text = "Registruj se";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(653, 683);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private Button btnRegistracija;

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