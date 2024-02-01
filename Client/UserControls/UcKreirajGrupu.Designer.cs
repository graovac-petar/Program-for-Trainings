using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcKreirajGrupu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNazivGrupe = new System.Windows.Forms.Label();
            this.lblDatumPocetka = new System.Windows.Forms.Label();
            this.lblDatumKraja = new System.Windows.Forms.Label();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.lblProgramTreninga = new System.Windows.Forms.Label();
            this.cbProgramTreninga = new System.Windows.Forms.ComboBox();
            this.lblPrijaveVanGrupeZaPt = new System.Windows.Forms.Label();
            this.lblPrijaveUGrupiZaProgramTreninga = new System.Windows.Forms.Label();
            this.dgvPrijaveVanGrupe = new System.Windows.Forms.DataGridView();
            this.dgvPrijaveUGrupi = new System.Windows.Forms.DataGridView();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblGreskaVanGrupe = new System.Windows.Forms.Label();
            this.lblGreskaPrijaveUGrupi = new System.Windows.Forms.Label();
            this.lblGreskaNazivGrupe = new System.Windows.Forms.Label();
            this.lblGreskaDatumKraja = new System.Windows.Forms.Label();
            this.lvlGreskaProgramTreninga = new System.Windows.Forms.Label();
            this.lblGreskaDatumPocetka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveVanGrupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveUGrupi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(335, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kreiraj grupu";
            // 
            // lblNazivGrupe
            // 
            this.lblNazivGrupe.AutoSize = true;
            this.lblNazivGrupe.Location = new System.Drawing.Point(120, 129);
            this.lblNazivGrupe.Name = "lblNazivGrupe";
            this.lblNazivGrupe.Size = new System.Drawing.Size(64, 13);
            this.lblNazivGrupe.TabIndex = 1;
            this.lblNazivGrupe.Text = "Naziv grupe";
            // 
            // lblDatumPocetka
            // 
            this.lblDatumPocetka.AutoSize = true;
            this.lblDatumPocetka.Location = new System.Drawing.Point(424, 136);
            this.lblDatumPocetka.Name = "lblDatumPocetka";
            this.lblDatumPocetka.Size = new System.Drawing.Size(81, 13);
            this.lblDatumPocetka.TabIndex = 3;
            this.lblDatumPocetka.Text = "Datum Pocetka";
            // 
            // lblDatumKraja
            // 
            this.lblDatumKraja.AutoSize = true;
            this.lblDatumKraja.Location = new System.Drawing.Point(424, 189);
            this.lblDatumKraja.Name = "lblDatumKraja";
            this.lblDatumKraja.Size = new System.Drawing.Size(65, 13);
            this.lblDatumKraja.TabIndex = 4;
            this.lblDatumKraja.Text = "Datum Kraja";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(214, 129);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(166, 20);
            this.txtNazivGrupe.TabIndex = 5;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(511, 136);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 6;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(511, 189);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(200, 20);
            this.dtpKraj.TabIndex = 7;
            // 
            // lblProgramTreninga
            // 
            this.lblProgramTreninga.AutoSize = true;
            this.lblProgramTreninga.Location = new System.Drawing.Point(120, 195);
            this.lblProgramTreninga.Name = "lblProgramTreninga";
            this.lblProgramTreninga.Size = new System.Drawing.Size(88, 13);
            this.lblProgramTreninga.TabIndex = 8;
            this.lblProgramTreninga.Text = "ProgramTreninga";
            // 
            // cbProgramTreninga
            // 
            this.cbProgramTreninga.FormattingEnabled = true;
            this.cbProgramTreninga.Location = new System.Drawing.Point(214, 188);
            this.cbProgramTreninga.Name = "cbProgramTreninga";
            this.cbProgramTreninga.Size = new System.Drawing.Size(166, 21);
            this.cbProgramTreninga.TabIndex = 9;
            // 
            // lblPrijaveVanGrupeZaPt
            // 
            this.lblPrijaveVanGrupeZaPt.AutoSize = true;
            this.lblPrijaveVanGrupeZaPt.Location = new System.Drawing.Point(56, 261);
            this.lblPrijaveVanGrupeZaPt.Name = "lblPrijaveVanGrupeZaPt";
            this.lblPrijaveVanGrupeZaPt.Size = new System.Drawing.Size(186, 13);
            this.lblPrijaveVanGrupeZaPt.TabIndex = 10;
            this.lblPrijaveVanGrupeZaPt.Text = "Prijave van grupe za program treninga";
            // 
            // lblPrijaveUGrupiZaProgramTreninga
            // 
            this.lblPrijaveUGrupiZaProgramTreninga.AutoSize = true;
            this.lblPrijaveUGrupiZaProgramTreninga.Location = new System.Drawing.Point(472, 261);
            this.lblPrijaveUGrupiZaProgramTreninga.Name = "lblPrijaveUGrupiZaProgramTreninga";
            this.lblPrijaveUGrupiZaProgramTreninga.Size = new System.Drawing.Size(170, 13);
            this.lblPrijaveUGrupiZaProgramTreninga.TabIndex = 11;
            this.lblPrijaveUGrupiZaProgramTreninga.Text = "Prijave u grupi za program treninga";
            // 
            // dgvPrijaveVanGrupe
            // 
            this.dgvPrijaveVanGrupe.AllowUserToAddRows = false;
            this.dgvPrijaveVanGrupe.AllowUserToDeleteRows = false;
            this.dgvPrijaveVanGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijaveVanGrupe.Location = new System.Drawing.Point(59, 300);
            this.dgvPrijaveVanGrupe.Name = "dgvPrijaveVanGrupe";
            this.dgvPrijaveVanGrupe.ReadOnly = true;
            this.dgvPrijaveVanGrupe.Size = new System.Drawing.Size(291, 206);
            this.dgvPrijaveVanGrupe.TabIndex = 12;
            // 
            // dgvPrijaveUGrupi
            // 
            this.dgvPrijaveUGrupi.AllowUserToAddRows = false;
            this.dgvPrijaveUGrupi.AllowUserToDeleteRows = false;
            this.dgvPrijaveUGrupi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijaveUGrupi.Location = new System.Drawing.Point(466, 300);
            this.dgvPrijaveUGrupi.Name = "dgvPrijaveUGrupi";
            this.dgvPrijaveUGrupi.ReadOnly = true;
            this.dgvPrijaveUGrupi.Size = new System.Drawing.Size(291, 206);
            this.dgvPrijaveUGrupi.TabIndex = 13;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(373, 352);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(75, 23);
            this.btnIzbaci.TabIndex = 14;
            this.btnIzbaci.Text = "<--";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(373, 408);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 15;
            this.btnUbaci.Text = "-->";
            this.btnUbaci.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(532, 538);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(156, 71);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(86, 538);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(156, 71);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi grupu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblGreskaVanGrupe
            // 
            this.lblGreskaVanGrupe.AutoSize = true;
            this.lblGreskaVanGrupe.Location = new System.Drawing.Point(56, 509);
            this.lblGreskaVanGrupe.Name = "lblGreskaVanGrupe";
            this.lblGreskaVanGrupe.Size = new System.Drawing.Size(29, 13);
            this.lblGreskaVanGrupe.TabIndex = 18;
            this.lblGreskaVanGrupe.Text = "label";
            this.lblGreskaVanGrupe.Visible = false;
            // 
            // lblGreskaPrijaveUGrupi
            // 
            this.lblGreskaPrijaveUGrupi.AutoSize = true;
            this.lblGreskaPrijaveUGrupi.Location = new System.Drawing.Point(463, 509);
            this.lblGreskaPrijaveUGrupi.Name = "lblGreskaPrijaveUGrupi";
            this.lblGreskaPrijaveUGrupi.Size = new System.Drawing.Size(29, 13);
            this.lblGreskaPrijaveUGrupi.TabIndex = 19;
            this.lblGreskaPrijaveUGrupi.Text = "label";
            this.lblGreskaPrijaveUGrupi.Visible = false;
            // 
            // lblGreskaNazivGrupe
            // 
            this.lblGreskaNazivGrupe.AutoSize = true;
            this.lblGreskaNazivGrupe.Location = new System.Drawing.Point(211, 152);
            this.lblGreskaNazivGrupe.Name = "lblGreskaNazivGrupe";
            this.lblGreskaNazivGrupe.Size = new System.Drawing.Size(29, 13);
            this.lblGreskaNazivGrupe.TabIndex = 20;
            this.lblGreskaNazivGrupe.Text = "label\r\n";
            this.lblGreskaNazivGrupe.Visible = false;
            // 
            // lblGreskaDatumKraja
            // 
            this.lblGreskaDatumKraja.AutoSize = true;
            this.lblGreskaDatumKraja.Location = new System.Drawing.Point(508, 212);
            this.lblGreskaDatumKraja.Name = "lblGreskaDatumKraja";
            this.lblGreskaDatumKraja.Size = new System.Drawing.Size(29, 13);
            this.lblGreskaDatumKraja.TabIndex = 21;
            this.lblGreskaDatumKraja.Text = "label";
            this.lblGreskaDatumKraja.Visible = false;
            // 
            // lvlGreskaProgramTreninga
            // 
            this.lvlGreskaProgramTreninga.AutoSize = true;
            this.lvlGreskaProgramTreninga.Location = new System.Drawing.Point(211, 212);
            this.lvlGreskaProgramTreninga.Name = "lvlGreskaProgramTreninga";
            this.lvlGreskaProgramTreninga.Size = new System.Drawing.Size(29, 13);
            this.lvlGreskaProgramTreninga.TabIndex = 22;
            this.lvlGreskaProgramTreninga.Text = "label";
            this.lvlGreskaProgramTreninga.Visible = false;
            // 
            // lblGreskaDatumPocetka
            // 
            this.lblGreskaDatumPocetka.AutoSize = true;
            this.lblGreskaDatumPocetka.Location = new System.Drawing.Point(508, 159);
            this.lblGreskaDatumPocetka.Name = "lblGreskaDatumPocetka";
            this.lblGreskaDatumPocetka.Size = new System.Drawing.Size(29, 13);
            this.lblGreskaDatumPocetka.TabIndex = 23;
            this.lblGreskaDatumPocetka.Text = "label";
            this.lblGreskaDatumPocetka.Visible = false;
            // 
            // UcKreirajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreskaDatumPocetka);
            this.Controls.Add(this.lvlGreskaProgramTreninga);
            this.Controls.Add(this.lblGreskaDatumKraja);
            this.Controls.Add(this.lblGreskaNazivGrupe);
            this.Controls.Add(this.lblGreskaPrijaveUGrupi);
            this.Controls.Add(this.lblGreskaVanGrupe);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.dgvPrijaveUGrupi);
            this.Controls.Add(this.dgvPrijaveVanGrupe);
            this.Controls.Add(this.lblPrijaveUGrupiZaProgramTreninga);
            this.Controls.Add(this.lblPrijaveVanGrupeZaPt);
            this.Controls.Add(this.cbProgramTreninga);
            this.Controls.Add(this.lblProgramTreninga);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.lblDatumKraja);
            this.Controls.Add(this.lblDatumPocetka);
            this.Controls.Add(this.lblNazivGrupe);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcKreirajGrupu";
            this.Size = new System.Drawing.Size(793, 652);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveVanGrupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveUGrupi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNazivGrupe;
        private System.Windows.Forms.Label lblDatumPocetka;
        private System.Windows.Forms.Label lblDatumKraja;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label lblProgramTreninga;
        private System.Windows.Forms.ComboBox cbProgramTreninga;
        private System.Windows.Forms.Label lblPrijaveVanGrupeZaPt;
        private System.Windows.Forms.Label lblPrijaveUGrupiZaProgramTreninga;
        private System.Windows.Forms.DataGridView dgvPrijaveVanGrupe;
        private System.Windows.Forms.DataGridView dgvPrijaveUGrupi;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private Label lblGreskaVanGrupe;
        private Label lblGreskaPrijaveUGrupi;
        private Label lblGreskaNazivGrupe;
        private Label lblGreskaDatumKraja;
        private Label lvlGreskaProgramTreninga;
        private Label lblGreskaDatumPocetka;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblNazivGrupe { get => lblNazivGrupe; set => lblNazivGrupe = value; }
        public Label LblDatumPocetka { get => lblDatumPocetka; set => lblDatumPocetka = value; }
        public Label LblDatumKraja { get => lblDatumKraja; set => lblDatumKraja = value; }
        public TextBox TxtNazivGrupe { get => txtNazivGrupe; set => txtNazivGrupe = value; }
        public DateTimePicker DtpPocetak { get => dtpPocetak; set => dtpPocetak = value; }
        public DateTimePicker DtpKraj { get => dtpKraj; set => dtpKraj = value; }
        public Label LblProgramTreninga { get => lblProgramTreninga; set => lblProgramTreninga = value; }
        public ComboBox CbProgramTreninga { get => cbProgramTreninga; set => cbProgramTreninga = value; }
        public Label LblPrijaveVanGrupeZaPt { get => lblPrijaveVanGrupeZaPt; set => lblPrijaveVanGrupeZaPt = value; }
        public Label LblPrijaveUGrupiZaProgramTreninga { get => lblPrijaveUGrupiZaProgramTreninga; set => lblPrijaveUGrupiZaProgramTreninga = value; }
        public DataGridView DgvPrijaveVanGrupe { get => dgvPrijaveVanGrupe; set => dgvPrijaveVanGrupe = value; }
        public DataGridView DgvPrijaveUGrupi { get => dgvPrijaveUGrupi; set => dgvPrijaveUGrupi = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Label LblGreskaVanGrupe { get => lblGreskaVanGrupe; set => lblGreskaVanGrupe = value; }
        public Label LblGreskaPrijaveUGrupi { get => lblGreskaPrijaveUGrupi; set => lblGreskaPrijaveUGrupi = value; }
        public Label LblGreskaNazivGrupe { get => lblGreskaNazivGrupe; set => lblGreskaNazivGrupe = value; }
        public Label LblGreskaDatumKraja { get => lblGreskaDatumKraja; set => lblGreskaDatumKraja = value; }
        public Label LblGreskaProgramTreninga { get => lvlGreskaProgramTreninga; set => lvlGreskaProgramTreninga = value; }
        public Label LblGreskaDatumPocetka { get => lblGreskaDatumPocetka; set => lblGreskaDatumPocetka = value; }
    }
}
