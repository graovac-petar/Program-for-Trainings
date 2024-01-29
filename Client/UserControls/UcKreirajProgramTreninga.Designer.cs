using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcKreirajProgramTreninga
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
            this.lblNazivProgramaTreninga = new System.Windows.Forms.Label();
            this.lblBrojTreningaNedeljno = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNazivProgramaTreninga = new System.Windows.Forms.TextBox();
            this.txtBrojTreningaNedeljno = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.btnObrisiTrening = new System.Windows.Forms.Button();
            this.cbDanUNedelji = new System.Windows.Forms.ComboBox();
            this.txtOpisTreninga = new System.Windows.Forms.TextBox();
            this.txtTrajanjeUMinutima = new System.Windows.Forms.TextBox();
            this.txtNazivTreninga = new System.Windows.Forms.TextBox();
            this.lblDanUNedelji = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblOpisTreninga = new System.Windows.Forms.Label();
            this.lblNazivTreninga = new System.Windows.Forms.Label();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(343, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kreiraj Program Treninga";
            // 
            // lblNazivProgramaTreninga
            // 
            this.lblNazivProgramaTreninga.AutoSize = true;
            this.lblNazivProgramaTreninga.Location = new System.Drawing.Point(90, 132);
            this.lblNazivProgramaTreninga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivProgramaTreninga.Name = "lblNazivProgramaTreninga";
            this.lblNazivProgramaTreninga.Size = new System.Drawing.Size(161, 16);
            this.lblNazivProgramaTreninga.TabIndex = 1;
            this.lblNazivProgramaTreninga.Text = "Naziv Programa Treninga";
            // 
            // lblBrojTreningaNedeljno
            // 
            this.lblBrojTreningaNedeljno.AutoSize = true;
            this.lblBrojTreningaNedeljno.Location = new System.Drawing.Point(483, 128);
            this.lblBrojTreningaNedeljno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojTreningaNedeljno.Name = "lblBrojTreningaNedeljno";
            this.lblBrojTreningaNedeljno.Size = new System.Drawing.Size(146, 16);
            this.lblBrojTreningaNedeljno.TabIndex = 2;
            this.lblBrojTreningaNedeljno.Text = "Broj Treninga Nedeljno";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(535, 176);
            this.lblCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(39, 16);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(150, 194);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(35, 16);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis";
            // 
            // txtNazivProgramaTreninga
            // 
            this.txtNazivProgramaTreninga.Location = new System.Drawing.Point(267, 128);
            this.txtNazivProgramaTreninga.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivProgramaTreninga.Name = "txtNazivProgramaTreninga";
            this.txtNazivProgramaTreninga.Size = new System.Drawing.Size(132, 22);
            this.txtNazivProgramaTreninga.TabIndex = 5;
            // 
            // txtBrojTreningaNedeljno
            // 
            this.txtBrojTreningaNedeljno.Location = new System.Drawing.Point(644, 128);
            this.txtBrojTreningaNedeljno.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojTreningaNedeljno.Name = "txtBrojTreningaNedeljno";
            this.txtBrojTreningaNedeljno.Size = new System.Drawing.Size(132, 22);
            this.txtBrojTreningaNedeljno.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(267, 188);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(132, 22);
            this.txtOpis.TabIndex = 7;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(640, 176);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(132, 22);
            this.txtCena.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajTermin);
            this.groupBox1.Controls.Add(this.btnObrisiTrening);
            this.groupBox1.Controls.Add(this.cbDanUNedelji);
            this.groupBox1.Controls.Add(this.txtOpisTreninga);
            this.groupBox1.Controls.Add(this.txtTrajanjeUMinutima);
            this.groupBox1.Controls.Add(this.txtNazivTreninga);
            this.groupBox1.Controls.Add(this.lblDanUNedelji);
            this.groupBox1.Controls.Add(this.lblTrajanje);
            this.groupBox1.Controls.Add(this.lblOpisTreninga);
            this.groupBox1.Controls.Add(this.lblNazivTreninga);
            this.groupBox1.Controls.Add(this.dgvTreninzi);
            this.groupBox1.Location = new System.Drawing.Point(85, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 405);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trening";
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.Location = new System.Drawing.Point(707, 310);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(130, 44);
            this.btnDodajTermin.TabIndex = 10;
            this.btnDodajTermin.Text = "Dodaj Termin";
            this.btnDodajTermin.UseVisualStyleBackColor = true;
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Location = new System.Drawing.Point(555, 310);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(130, 44);
            this.btnObrisiTrening.TabIndex = 9;
            this.btnObrisiTrening.Text = "Obrisi trening";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            // 
            // cbDanUNedelji
            // 
            this.cbDanUNedelji.FormattingEnabled = true;
            this.cbDanUNedelji.Location = new System.Drawing.Point(678, 238);
            this.cbDanUNedelji.Name = "cbDanUNedelji";
            this.cbDanUNedelji.Size = new System.Drawing.Size(159, 24);
            this.cbDanUNedelji.TabIndex = 8;
            // 
            // txtOpisTreninga
            // 
            this.txtOpisTreninga.Location = new System.Drawing.Point(678, 86);
            this.txtOpisTreninga.Multiline = true;
            this.txtOpisTreninga.Name = "txtOpisTreninga";
            this.txtOpisTreninga.Size = new System.Drawing.Size(159, 80);
            this.txtOpisTreninga.TabIndex = 7;
            // 
            // txtTrajanjeUMinutima
            // 
            this.txtTrajanjeUMinutima.Location = new System.Drawing.Point(678, 189);
            this.txtTrajanjeUMinutima.Name = "txtTrajanjeUMinutima";
            this.txtTrajanjeUMinutima.Size = new System.Drawing.Size(159, 22);
            this.txtTrajanjeUMinutima.TabIndex = 6;
            // 
            // txtNazivTreninga
            // 
            this.txtNazivTreninga.Location = new System.Drawing.Point(680, 41);
            this.txtNazivTreninga.Name = "txtNazivTreninga";
            this.txtNazivTreninga.Size = new System.Drawing.Size(159, 22);
            this.txtNazivTreninga.TabIndex = 5;
            // 
            // lblDanUNedelji
            // 
            this.lblDanUNedelji.AutoSize = true;
            this.lblDanUNedelji.Location = new System.Drawing.Point(552, 241);
            this.lblDanUNedelji.Name = "lblDanUNedelji";
            this.lblDanUNedelji.Size = new System.Drawing.Size(91, 16);
            this.lblDanUNedelji.TabIndex = 4;
            this.lblDanUNedelji.Text = "Dan U Nedelji";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(552, 192);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(120, 16);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "TrajanjeUMinutima";
            // 
            // lblOpisTreninga
            // 
            this.lblOpisTreninga.AutoSize = true;
            this.lblOpisTreninga.Location = new System.Drawing.Point(552, 89);
            this.lblOpisTreninga.Name = "lblOpisTreninga";
            this.lblOpisTreninga.Size = new System.Drawing.Size(86, 16);
            this.lblOpisTreninga.TabIndex = 2;
            this.lblOpisTreninga.Text = "Opis treninga";
            // 
            // lblNazivTreninga
            // 
            this.lblNazivTreninga.AutoSize = true;
            this.lblNazivTreninga.Location = new System.Drawing.Point(552, 41);
            this.lblNazivTreninga.Name = "lblNazivTreninga";
            this.lblNazivTreninga.Size = new System.Drawing.Size(95, 16);
            this.lblNazivTreninga.TabIndex = 1;
            this.lblNazivTreninga.Text = "NazivTreninga";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(25, 21);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(519, 341);
            this.dgvTreninzi.TabIndex = 0;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(807, 641);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(145, 55);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(85, 641);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(145, 55);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi program treninga";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UcKreirajProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtBrojTreningaNedeljno);
            this.Controls.Add(this.txtNazivProgramaTreninga);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblBrojTreningaNedeljno);
            this.Controls.Add(this.lblNazivProgramaTreninga);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcKreirajProgramTreninga";
            this.Size = new System.Drawing.Size(977, 833);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNazivProgramaTreninga;
        private System.Windows.Forms.Label lblBrojTreningaNedeljno;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNazivProgramaTreninga;
        private System.Windows.Forms.TextBox txtBrojTreningaNedeljno;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.Label lblDanUNedelji;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblOpisTreninga;
        private System.Windows.Forms.Label lblNazivTreninga;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Button btnObrisiTrening;
        private System.Windows.Forms.ComboBox cbDanUNedelji;
        private System.Windows.Forms.TextBox txtOpisTreninga;
        private System.Windows.Forms.TextBox txtTrajanjeUMinutima;
        private System.Windows.Forms.TextBox txtNazivTreninga;
        private Button btnSacuvaj;
        private Button btnObrisi;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblNazivProgramaTreninga { get => lblNazivProgramaTreninga; set => lblNazivProgramaTreninga = value; }
        public Label LblBrojTreningaNedeljno { get => lblBrojTreningaNedeljno; set => lblBrojTreningaNedeljno = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public TextBox TxtNazivProgramaTreninga { get => txtNazivProgramaTreninga; set => txtNazivProgramaTreninga = value; }
        public TextBox TxtBrojTreningaNedeljno { get => txtBrojTreningaNedeljno; set => txtBrojTreningaNedeljno = value; }
        public TextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public DataGridView DgvTreninzi { get => dgvTreninzi; set => dgvTreninzi = value; }
        public Label LblDanUNedelji { get => lblDanUNedelji; set => lblDanUNedelji = value; }
        public Label LblTrajanje { get => lblTrajanje; set => lblTrajanje = value; }
        public Label LblOpisTreninga { get => lblOpisTreninga; set => lblOpisTreninga = value; }
        public Label LblNazivTreninga { get => lblNazivTreninga; set => lblNazivTreninga = value; }
        public Button BtnDodajTermin { get => btnDodajTermin; set => btnDodajTermin = value; }
        public Button BtnObrisiTrening { get => btnObrisiTrening; set => btnObrisiTrening = value; }
        public ComboBox CbDanUNedelji { get => cbDanUNedelji; set => cbDanUNedelji = value; }
        public TextBox TxtOpisTreninga { get => txtOpisTreninga; set => txtOpisTreninga = value; }
        public TextBox TxtTrajanjeUMinutima { get => txtTrajanjeUMinutima; set => txtTrajanjeUMinutima = value; }
        public TextBox TxtNazivTreninga { get => txtNazivTreninga; set => txtNazivTreninga = value; }
    }
}
