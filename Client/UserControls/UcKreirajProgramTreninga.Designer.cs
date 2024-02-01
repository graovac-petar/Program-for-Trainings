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
            this.lblGreskaBrisanje = new System.Windows.Forms.Label();
            this.lblGreskaDanUNedelji = new System.Windows.Forms.Label();
            this.lblGreskaTrajanje = new System.Windows.Forms.Label();
            this.lblGreskaOpisTreninga = new System.Windows.Forms.Label();
            this.lblGreskaNazivTreninga = new System.Windows.Forms.Label();
            this.btnDodajTrening = new System.Windows.Forms.Button();
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
            this.lblGreskaNazivProgramaTreninga = new System.Windows.Forms.Label();
            this.lblGreskaOpisProgramaTreninga = new System.Windows.Forms.Label();
            this.lblGreskaBrojTreningaNedeljno = new System.Windows.Forms.Label();
            this.lblGreskaCena = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(257, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kreiraj Program Treninga";
            // 
            // lblNazivProgramaTreninga
            // 
            this.lblNazivProgramaTreninga.AutoSize = true;
            this.lblNazivProgramaTreninga.Location = new System.Drawing.Point(68, 107);
            this.lblNazivProgramaTreninga.Name = "lblNazivProgramaTreninga";
            this.lblNazivProgramaTreninga.Size = new System.Drawing.Size(127, 13);
            this.lblNazivProgramaTreninga.TabIndex = 1;
            this.lblNazivProgramaTreninga.Text = "Naziv Programa Treninga";
            // 
            // lblBrojTreningaNedeljno
            // 
            this.lblBrojTreningaNedeljno.AutoSize = true;
            this.lblBrojTreningaNedeljno.Location = new System.Drawing.Point(362, 104);
            this.lblBrojTreningaNedeljno.Name = "lblBrojTreningaNedeljno";
            this.lblBrojTreningaNedeljno.Size = new System.Drawing.Size(115, 13);
            this.lblBrojTreningaNedeljno.TabIndex = 2;
            this.lblBrojTreningaNedeljno.Text = "Broj Treninga Nedeljno";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(404, 143);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(32, 13);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(112, 148);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(28, 13);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis";
            // 
            // txtNazivProgramaTreninga
            // 
            this.txtNazivProgramaTreninga.Location = new System.Drawing.Point(200, 104);
            this.txtNazivProgramaTreninga.Name = "txtNazivProgramaTreninga";
            this.txtNazivProgramaTreninga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivProgramaTreninga.TabIndex = 5;
            // 
            // txtBrojTreningaNedeljno
            // 
            this.txtBrojTreningaNedeljno.Location = new System.Drawing.Point(483, 104);
            this.txtBrojTreningaNedeljno.Name = "txtBrojTreningaNedeljno";
            this.txtBrojTreningaNedeljno.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTreningaNedeljno.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(200, 143);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 7;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(483, 143);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGreskaBrisanje);
            this.groupBox1.Controls.Add(this.lblGreskaDanUNedelji);
            this.groupBox1.Controls.Add(this.lblGreskaTrajanje);
            this.groupBox1.Controls.Add(this.lblGreskaOpisTreninga);
            this.groupBox1.Controls.Add(this.lblGreskaNazivTreninga);
            this.groupBox1.Controls.Add(this.btnDodajTrening);
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
            this.groupBox1.Location = new System.Drawing.Point(64, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(650, 329);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trening";
            // 
            // lblGreskaBrisanje
            // 
            this.lblGreskaBrisanje.AutoSize = true;
            this.lblGreskaBrisanje.Location = new System.Drawing.Point(16, 301);
            this.lblGreskaBrisanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaBrisanje.Name = "lblGreskaBrisanje";
            this.lblGreskaBrisanje.Size = new System.Drawing.Size(57, 13);
            this.lblGreskaBrisanje.TabIndex = 15;
            this.lblGreskaBrisanje.Text = "GreskaList";
            this.lblGreskaBrisanje.Visible = false;
            // 
            // lblGreskaDanUNedelji
            // 
            this.lblGreskaDanUNedelji.AutoSize = true;
            this.lblGreskaDanUNedelji.Location = new System.Drawing.Point(516, 254);
            this.lblGreskaDanUNedelji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaDanUNedelji.Name = "lblGreskaDanUNedelji";
            this.lblGreskaDanUNedelji.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaDanUNedelji.TabIndex = 14;
            this.lblGreskaDanUNedelji.Text = "label3";
            // 
            // lblGreskaTrajanje
            // 
            this.lblGreskaTrajanje.AutoSize = true;
            this.lblGreskaTrajanje.Location = new System.Drawing.Point(516, 201);
            this.lblGreskaTrajanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaTrajanje.Name = "lblGreskaTrajanje";
            this.lblGreskaTrajanje.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaTrajanje.TabIndex = 13;
            this.lblGreskaTrajanje.Text = "label2";
            // 
            // lblGreskaOpisTreninga
            // 
            this.lblGreskaOpisTreninga.AutoSize = true;
            this.lblGreskaOpisTreninga.Location = new System.Drawing.Point(516, 160);
            this.lblGreskaOpisTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaOpisTreninga.Name = "lblGreskaOpisTreninga";
            this.lblGreskaOpisTreninga.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaOpisTreninga.TabIndex = 12;
            this.lblGreskaOpisTreninga.Text = "label1";
            // 
            // lblGreskaNazivTreninga
            // 
            this.lblGreskaNazivTreninga.AutoSize = true;
            this.lblGreskaNazivTreninga.Location = new System.Drawing.Point(516, 55);
            this.lblGreskaNazivTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaNazivTreninga.Name = "lblGreskaNazivTreninga";
            this.lblGreskaNazivTreninga.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaNazivTreninga.TabIndex = 11;
            this.lblGreskaNazivTreninga.Text = "label1";
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Location = new System.Drawing.Point(541, 289);
            this.btnDodajTrening.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(98, 36);
            this.btnDodajTrening.TabIndex = 10;
            this.btnDodajTrening.Text = "Dodaj Trening";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Location = new System.Drawing.Point(419, 289);
            this.btnObrisiTrening.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(98, 36);
            this.btnObrisiTrening.TabIndex = 9;
            this.btnObrisiTrening.Text = "Obrisi trening";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            // 
            // cbDanUNedelji
            // 
            this.cbDanUNedelji.FormattingEnabled = true;
            this.cbDanUNedelji.Location = new System.Drawing.Point(519, 231);
            this.cbDanUNedelji.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanUNedelji.Name = "cbDanUNedelji";
            this.cbDanUNedelji.Size = new System.Drawing.Size(120, 21);
            this.cbDanUNedelji.TabIndex = 8;
            // 
            // txtOpisTreninga
            // 
            this.txtOpisTreninga.Location = new System.Drawing.Point(519, 92);
            this.txtOpisTreninga.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisTreninga.Multiline = true;
            this.txtOpisTreninga.Name = "txtOpisTreninga";
            this.txtOpisTreninga.Size = new System.Drawing.Size(120, 66);
            this.txtOpisTreninga.TabIndex = 7;
            // 
            // txtTrajanjeUMinutima
            // 
            this.txtTrajanjeUMinutima.Location = new System.Drawing.Point(519, 179);
            this.txtTrajanjeUMinutima.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrajanjeUMinutima.Name = "txtTrajanjeUMinutima";
            this.txtTrajanjeUMinutima.Size = new System.Drawing.Size(120, 20);
            this.txtTrajanjeUMinutima.TabIndex = 6;
            // 
            // txtNazivTreninga
            // 
            this.txtNazivTreninga.Location = new System.Drawing.Point(519, 33);
            this.txtNazivTreninga.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivTreninga.Name = "txtNazivTreninga";
            this.txtNazivTreninga.Size = new System.Drawing.Size(120, 20);
            this.txtNazivTreninga.TabIndex = 5;
            // 
            // lblDanUNedelji
            // 
            this.lblDanUNedelji.AutoSize = true;
            this.lblDanUNedelji.Location = new System.Drawing.Point(427, 231);
            this.lblDanUNedelji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanUNedelji.Name = "lblDanUNedelji";
            this.lblDanUNedelji.Size = new System.Drawing.Size(73, 13);
            this.lblDanUNedelji.TabIndex = 4;
            this.lblDanUNedelji.Text = "Dan U Nedelji";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(420, 179);
            this.lblTrajanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(95, 13);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "TrajanjeUMinutima";
            // 
            // lblOpisTreninga
            // 
            this.lblOpisTreninga.AutoSize = true;
            this.lblOpisTreninga.Location = new System.Drawing.Point(424, 92);
            this.lblOpisTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisTreninga.Name = "lblOpisTreninga";
            this.lblOpisTreninga.Size = new System.Drawing.Size(69, 13);
            this.lblOpisTreninga.TabIndex = 2;
            this.lblOpisTreninga.Text = "Opis treninga";
            // 
            // lblNazivTreninga
            // 
            this.lblNazivTreninga.AutoSize = true;
            this.lblNazivTreninga.Location = new System.Drawing.Point(424, 40);
            this.lblNazivTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivTreninga.Name = "lblNazivTreninga";
            this.lblNazivTreninga.Size = new System.Drawing.Size(76, 13);
            this.lblNazivTreninga.TabIndex = 1;
            this.lblNazivTreninga.Text = "NazivTreninga";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(19, 17);
            this.dgvTreninzi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(389, 277);
            this.dgvTreninzi.TabIndex = 0;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(605, 521);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(109, 45);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(64, 521);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(109, 45);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi program treninga";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblGreskaNazivProgramaTreninga
            // 
            this.lblGreskaNazivProgramaTreninga.AutoSize = true;
            this.lblGreskaNazivProgramaTreninga.Location = new System.Drawing.Point(197, 127);
            this.lblGreskaNazivProgramaTreninga.Name = "lblGreskaNazivProgramaTreninga";
            this.lblGreskaNazivProgramaTreninga.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaNazivProgramaTreninga.TabIndex = 12;
            this.lblGreskaNazivProgramaTreninga.Text = "label1";
            this.lblGreskaNazivProgramaTreninga.Visible = false;
            // 
            // lblGreskaOpisProgramaTreninga
            // 
            this.lblGreskaOpisProgramaTreninga.AutoSize = true;
            this.lblGreskaOpisProgramaTreninga.Location = new System.Drawing.Point(197, 166);
            this.lblGreskaOpisProgramaTreninga.Name = "lblGreskaOpisProgramaTreninga";
            this.lblGreskaOpisProgramaTreninga.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaOpisProgramaTreninga.TabIndex = 13;
            this.lblGreskaOpisProgramaTreninga.Text = "label1";
            this.lblGreskaOpisProgramaTreninga.Visible = false;
            // 
            // lblGreskaBrojTreningaNedeljno
            // 
            this.lblGreskaBrojTreningaNedeljno.AutoSize = true;
            this.lblGreskaBrojTreningaNedeljno.Location = new System.Drawing.Point(480, 127);
            this.lblGreskaBrojTreningaNedeljno.Name = "lblGreskaBrojTreningaNedeljno";
            this.lblGreskaBrojTreningaNedeljno.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaBrojTreningaNedeljno.TabIndex = 14;
            this.lblGreskaBrojTreningaNedeljno.Text = "label1";
            this.lblGreskaBrojTreningaNedeljno.Visible = false;
            // 
            // lblGreskaCena
            // 
            this.lblGreskaCena.AutoSize = true;
            this.lblGreskaCena.Location = new System.Drawing.Point(480, 166);
            this.lblGreskaCena.Name = "lblGreskaCena";
            this.lblGreskaCena.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaCena.TabIndex = 15;
            this.lblGreskaCena.Text = "label1";
            this.lblGreskaCena.Visible = false;
            // 
            // UcKreirajProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreskaCena);
            this.Controls.Add(this.lblGreskaBrojTreningaNedeljno);
            this.Controls.Add(this.lblGreskaOpisProgramaTreninga);
            this.Controls.Add(this.lblGreskaNazivProgramaTreninga);
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
            this.Name = "UcKreirajProgramTreninga";
            this.Size = new System.Drawing.Size(733, 677);
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
        private System.Windows.Forms.Button btnDodajTrening;
        private System.Windows.Forms.Button btnObrisiTrening;
        private System.Windows.Forms.ComboBox cbDanUNedelji;
        private System.Windows.Forms.TextBox txtOpisTreninga;
        private System.Windows.Forms.TextBox txtTrajanjeUMinutima;
        private System.Windows.Forms.TextBox txtNazivTreninga;
        private Button btnSacuvaj;
        private Button btnObrisi;
        private Label lblGreskaDanUNedelji;
        private Label lblGreskaTrajanje;
        private Label lblGreskaOpisTreninga;
        private Label lblGreskaNazivTreninga;
        private Label lblGreskaBrisanje;
        private Label lblGreskaNazivProgramaTreninga;
        private Label lblGreskaOpisProgramaTreninga;
        private Label lblGreskaBrojTreningaNedeljno;
        private Label lblGreskaCena;

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
        public Button BtnDodajTrening { get => btnDodajTrening; set => btnDodajTrening = value; }
        public Button BtnObrisiTrening { get => btnObrisiTrening; set => btnObrisiTrening = value; }
        public ComboBox CbDanUNedelji { get => cbDanUNedelji; set => cbDanUNedelji = value; }
        public TextBox TxtOpisTreninga { get => txtOpisTreninga; set => txtOpisTreninga = value; }
        public TextBox TxtTrajanjeUMinutima { get => txtTrajanjeUMinutima; set => txtTrajanjeUMinutima = value; }
        public TextBox TxtNazivTreninga { get => txtNazivTreninga; set => txtNazivTreninga = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Label LblGreskaDanUNedelji { get => lblGreskaDanUNedelji; set => lblGreskaDanUNedelji = value; }
        public Label LblGreskaTrajanje { get => lblGreskaTrajanje; set => lblGreskaTrajanje = value; }
        public Label LblGreskaOpisTreninga { get => lblGreskaOpisTreninga; set => lblGreskaOpisTreninga = value; }
        public Label LblGreskaNazivTreninga { get => lblGreskaNazivTreninga; set => lblGreskaNazivTreninga = value; }
        public Label LblGreskaBrisanje { get => lblGreskaBrisanje; set => lblGreskaBrisanje = value; }
        public Label LblGreskaNazivProgramaTreninga { get => lblGreskaNazivProgramaTreninga; set => lblGreskaNazivProgramaTreninga = value; }
        public Label LblGreskaOpisProgramaTreninga { get => lblGreskaOpisProgramaTreninga; set => lblGreskaOpisProgramaTreninga = value; }
        public Label LblGreskaBrojTreningaNedeljno { get => lblGreskaBrojTreningaNedeljno; set => lblGreskaBrojTreningaNedeljno = value; }
        public Label LblGreskaCena { get => lblGreskaCena; set => lblGreskaCena = value; }
    }
}
