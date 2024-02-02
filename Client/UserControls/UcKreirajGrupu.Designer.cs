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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveVanGrupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveUGrupi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblTitle.Location = new System.Drawing.Point(440, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kreiraj grupu";
            // 
            // lblNazivGrupe
            // 
            this.lblNazivGrupe.AutoSize = true;
            this.lblNazivGrupe.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblNazivGrupe.Location = new System.Drawing.Point(13, 130);
            this.lblNazivGrupe.Name = "lblNazivGrupe";
            this.lblNazivGrupe.Size = new System.Drawing.Size(170, 35);
            this.lblNazivGrupe.TabIndex = 1;
            this.lblNazivGrupe.Text = "Naziv grupe";
            // 
            // lblDatumPocetka
            // 
            this.lblDatumPocetka.AutoSize = true;
            this.lblDatumPocetka.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblDatumPocetka.Location = new System.Drawing.Point(569, 135);
            this.lblDatumPocetka.Name = "lblDatumPocetka";
            this.lblDatumPocetka.Size = new System.Drawing.Size(209, 35);
            this.lblDatumPocetka.TabIndex = 3;
            this.lblDatumPocetka.Text = "Datum Pocetka";
            // 
            // lblDatumKraja
            // 
            this.lblDatumKraja.AutoSize = true;
            this.lblDatumKraja.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblDatumKraja.Location = new System.Drawing.Point(569, 203);
            this.lblDatumKraja.Name = "lblDatumKraja";
            this.lblDatumKraja.Size = new System.Drawing.Size(176, 35);
            this.lblDatumKraja.TabIndex = 4;
            this.lblDatumKraja.Text = "Datum Kraja";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNazivGrupe.Location = new System.Drawing.Point(189, 135);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(362, 33);
            this.txtNazivGrupe.TabIndex = 5;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.dtpPocetak.Location = new System.Drawing.Point(784, 137);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(344, 33);
            this.dtpPocetak.TabIndex = 6;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.dtpKraj.Location = new System.Drawing.Point(784, 203);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(344, 33);
            this.dtpKraj.TabIndex = 7;
            // 
            // lblProgramTreninga
            // 
            this.lblProgramTreninga.AutoSize = true;
            this.lblProgramTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblProgramTreninga.Location = new System.Drawing.Point(13, 214);
            this.lblProgramTreninga.Name = "lblProgramTreninga";
            this.lblProgramTreninga.Size = new System.Drawing.Size(238, 35);
            this.lblProgramTreninga.TabIndex = 8;
            this.lblProgramTreninga.Text = "ProgramTreninga";
            // 
            // cbProgramTreninga
            // 
            this.cbProgramTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.cbProgramTreninga.FormattingEnabled = true;
            this.cbProgramTreninga.Location = new System.Drawing.Point(257, 214);
            this.cbProgramTreninga.Name = "cbProgramTreninga";
            this.cbProgramTreninga.Size = new System.Drawing.Size(294, 33);
            this.cbProgramTreninga.TabIndex = 9;
            // 
            // lblPrijaveVanGrupeZaPt
            // 
            this.lblPrijaveVanGrupeZaPt.AutoSize = true;
            this.lblPrijaveVanGrupeZaPt.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblPrijaveVanGrupeZaPt.Location = new System.Drawing.Point(13, 289);
            this.lblPrijaveVanGrupeZaPt.Name = "lblPrijaveVanGrupeZaPt";
            this.lblPrijaveVanGrupeZaPt.Size = new System.Drawing.Size(515, 35);
            this.lblPrijaveVanGrupeZaPt.TabIndex = 10;
            this.lblPrijaveVanGrupeZaPt.Text = "Prijave van grupe za program treninga";
            // 
            // lblPrijaveUGrupiZaProgramTreninga
            // 
            this.lblPrijaveUGrupiZaProgramTreninga.AutoSize = true;
            this.lblPrijaveUGrupiZaProgramTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblPrijaveUGrupiZaProgramTreninga.Location = new System.Drawing.Point(613, 289);
            this.lblPrijaveUGrupiZaProgramTreninga.Name = "lblPrijaveUGrupiZaProgramTreninga";
            this.lblPrijaveUGrupiZaProgramTreninga.Size = new System.Drawing.Size(476, 35);
            this.lblPrijaveUGrupiZaProgramTreninga.TabIndex = 11;
            this.lblPrijaveUGrupiZaProgramTreninga.Text = "Prijave u grupi za program treninga";
            // 
            // dgvPrijaveVanGrupe
            // 
            this.dgvPrijaveVanGrupe.AllowUserToAddRows = false;
            this.dgvPrijaveVanGrupe.AllowUserToDeleteRows = false;
            this.dgvPrijaveVanGrupe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrijaveVanGrupe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrijaveVanGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijaveVanGrupe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrijaveVanGrupe.Location = new System.Drawing.Point(0, 0);
            this.dgvPrijaveVanGrupe.Name = "dgvPrijaveVanGrupe";
            this.dgvPrijaveVanGrupe.ReadOnly = true;
            this.dgvPrijaveVanGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijaveVanGrupe.Size = new System.Drawing.Size(509, 349);
            this.dgvPrijaveVanGrupe.TabIndex = 12;
            // 
            // dgvPrijaveUGrupi
            // 
            this.dgvPrijaveUGrupi.AllowUserToAddRows = false;
            this.dgvPrijaveUGrupi.AllowUserToDeleteRows = false;
            this.dgvPrijaveUGrupi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrijaveUGrupi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrijaveUGrupi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijaveUGrupi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrijaveUGrupi.Location = new System.Drawing.Point(0, 0);
            this.dgvPrijaveUGrupi.Name = "dgvPrijaveUGrupi";
            this.dgvPrijaveUGrupi.ReadOnly = true;
            this.dgvPrijaveUGrupi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijaveUGrupi.Size = new System.Drawing.Size(509, 349);
            this.dgvPrijaveUGrupi.TabIndex = 13;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Font = new System.Drawing.Font("Arial Nova", 24F, System.Drawing.FontStyle.Bold);
            this.btnIzbaci.Location = new System.Drawing.Point(531, 447);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(82, 63);
            this.btnIzbaci.TabIndex = 14;
            this.btnIzbaci.Text = "<--";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // btnUbaci
            // 
            this.btnUbaci.Font = new System.Drawing.Font("Arial Nova", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaci.Location = new System.Drawing.Point(531, 539);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(82, 63);
            this.btnUbaci.TabIndex = 15;
            this.btnUbaci.Text = "-->";
            this.btnUbaci.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DarkRed;
            this.btnSacuvaj.Font = new System.Drawing.Font("Bahnschrift", 19.75F);
            this.btnSacuvaj.Location = new System.Drawing.Point(769, 730);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(250, 71);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnObrisi.Font = new System.Drawing.Font("Bahnschrift", 19.75F);
            this.btnObrisi.Location = new System.Drawing.Point(133, 730);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(250, 71);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi grupu";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // lblGreskaVanGrupe
            // 
            this.lblGreskaVanGrupe.AutoSize = true;
            this.lblGreskaVanGrupe.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaVanGrupe.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaVanGrupe.Location = new System.Drawing.Point(14, 699);
            this.lblGreskaVanGrupe.Name = "lblGreskaVanGrupe";
            this.lblGreskaVanGrupe.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaVanGrupe.TabIndex = 18;
            this.lblGreskaVanGrupe.Text = "label";
            this.lblGreskaVanGrupe.Visible = false;
            // 
            // lblGreskaPrijaveUGrupi
            // 
            this.lblGreskaPrijaveUGrupi.AutoSize = true;
            this.lblGreskaPrijaveUGrupi.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaPrijaveUGrupi.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaPrijaveUGrupi.Location = new System.Drawing.Point(614, 699);
            this.lblGreskaPrijaveUGrupi.Name = "lblGreskaPrijaveUGrupi";
            this.lblGreskaPrijaveUGrupi.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaPrijaveUGrupi.TabIndex = 19;
            this.lblGreskaPrijaveUGrupi.Text = "label";
            this.lblGreskaPrijaveUGrupi.Visible = false;
            // 
            // lblGreskaNazivGrupe
            // 
            this.lblGreskaNazivGrupe.AutoSize = true;
            this.lblGreskaNazivGrupe.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaNazivGrupe.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaNazivGrupe.Location = new System.Drawing.Point(185, 171);
            this.lblGreskaNazivGrupe.Name = "lblGreskaNazivGrupe";
            this.lblGreskaNazivGrupe.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaNazivGrupe.TabIndex = 20;
            this.lblGreskaNazivGrupe.Text = "label\r\n";
            this.lblGreskaNazivGrupe.Visible = false;
            // 
            // lblGreskaDatumKraja
            // 
            this.lblGreskaDatumKraja.AutoSize = true;
            this.lblGreskaDatumKraja.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaDatumKraja.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaDatumKraja.Location = new System.Drawing.Point(780, 239);
            this.lblGreskaDatumKraja.Name = "lblGreskaDatumKraja";
            this.lblGreskaDatumKraja.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaDatumKraja.TabIndex = 21;
            this.lblGreskaDatumKraja.Text = "label";
            this.lblGreskaDatumKraja.Visible = false;
            // 
            // lvlGreskaProgramTreninga
            // 
            this.lvlGreskaProgramTreninga.AutoSize = true;
            this.lvlGreskaProgramTreninga.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lvlGreskaProgramTreninga.ForeColor = System.Drawing.Color.Red;
            this.lvlGreskaProgramTreninga.Location = new System.Drawing.Point(253, 250);
            this.lvlGreskaProgramTreninga.Name = "lvlGreskaProgramTreninga";
            this.lvlGreskaProgramTreninga.Size = new System.Drawing.Size(46, 19);
            this.lvlGreskaProgramTreninga.TabIndex = 22;
            this.lvlGreskaProgramTreninga.Text = "label";
            this.lvlGreskaProgramTreninga.Visible = false;
            // 
            // lblGreskaDatumPocetka
            // 
            this.lblGreskaDatumPocetka.AutoSize = true;
            this.lblGreskaDatumPocetka.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaDatumPocetka.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaDatumPocetka.Location = new System.Drawing.Point(780, 173);
            this.lblGreskaDatumPocetka.Name = "lblGreskaDatumPocetka";
            this.lblGreskaDatumPocetka.Size = new System.Drawing.Size(46, 19);
            this.lblGreskaDatumPocetka.TabIndex = 23;
            this.lblGreskaDatumPocetka.Text = "label";
            this.lblGreskaDatumPocetka.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrijaveVanGrupe);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.panel1.Location = new System.Drawing.Point(19, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 349);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPrijaveUGrupi);
            this.panel2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(619, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 349);
            this.panel2.TabIndex = 25;
            // 
            // UcKreirajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Size = new System.Drawing.Size(1163, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveVanGrupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijaveUGrupi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;

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
