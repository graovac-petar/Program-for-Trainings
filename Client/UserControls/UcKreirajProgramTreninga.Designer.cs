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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblGreskaNazivProgramaTreninga = new System.Windows.Forms.Label();
            this.lblGreskaOpisProgramaTreninga = new System.Windows.Forms.Label();
            this.lblGreskaBrojTreningaNedeljno = new System.Windows.Forms.Label();
            this.lblGreskaCena = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblTitle.Location = new System.Drawing.Point(336, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kreiraj Program Treninga";
            // 
            // lblNazivProgramaTreninga
            // 
            this.lblNazivProgramaTreninga.AutoSize = true;
            this.lblNazivProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblNazivProgramaTreninga.Location = new System.Drawing.Point(3, 110);
            this.lblNazivProgramaTreninga.Name = "lblNazivProgramaTreninga";
            this.lblNazivProgramaTreninga.Size = new System.Drawing.Size(336, 35);
            this.lblNazivProgramaTreninga.TabIndex = 1;
            this.lblNazivProgramaTreninga.Text = "Naziv programa treninga";
            // 
            // lblBrojTreningaNedeljno
            // 
            this.lblBrojTreningaNedeljno.AutoSize = true;
            this.lblBrojTreningaNedeljno.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblBrojTreningaNedeljno.Location = new System.Drawing.Point(613, 108);
            this.lblBrojTreningaNedeljno.Name = "lblBrojTreningaNedeljno";
            this.lblBrojTreningaNedeljno.Size = new System.Drawing.Size(313, 35);
            this.lblBrojTreningaNedeljno.TabIndex = 2;
            this.lblBrojTreningaNedeljno.Text = "Broj Treninga Nedeljno";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblCena.Location = new System.Drawing.Point(614, 194);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(80, 35);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblOpis.Location = new System.Drawing.Point(3, 189);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(322, 35);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis programa treninga";
            // 
            // txtNazivProgramaTreninga
            // 
            this.txtNazivProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNazivProgramaTreninga.Location = new System.Drawing.Point(346, 110);
            this.txtNazivProgramaTreninga.Name = "txtNazivProgramaTreninga";
            this.txtNazivProgramaTreninga.Size = new System.Drawing.Size(261, 33);
            this.txtNazivProgramaTreninga.TabIndex = 5;
            // 
            // txtBrojTreningaNedeljno
            // 
            this.txtBrojTreningaNedeljno.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtBrojTreningaNedeljno.Location = new System.Drawing.Point(932, 110);
            this.txtBrojTreningaNedeljno.Name = "txtBrojTreningaNedeljno";
            this.txtBrojTreningaNedeljno.Size = new System.Drawing.Size(204, 33);
            this.txtBrojTreningaNedeljno.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtOpis.Location = new System.Drawing.Point(346, 194);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(262, 33);
            this.txtOpis.TabIndex = 7;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtCena.Location = new System.Drawing.Point(717, 196);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(419, 33);
            this.txtCena.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
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
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.groupBox1.Location = new System.Drawing.Point(9, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1127, 478);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trening";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTreninzi);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.panel1.Location = new System.Drawing.Point(22, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 407);
            this.panel1.TabIndex = 16;
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreninzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreninzi.Location = new System.Drawing.Point(0, 0);
            this.dgvTreninzi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(577, 407);
            this.dgvTreninzi.TabIndex = 0;
            // 
            // lblGreskaBrisanje
            // 
            this.lblGreskaBrisanje.AutoSize = true;
            this.lblGreskaBrisanje.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.lblGreskaBrisanje.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaBrisanje.Location = new System.Drawing.Point(17, 449);
            this.lblGreskaBrisanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaBrisanje.Name = "lblGreskaBrisanje";
            this.lblGreskaBrisanje.Size = new System.Drawing.Size(119, 27);
            this.lblGreskaBrisanje.TabIndex = 15;
            this.lblGreskaBrisanje.Text = "GreskaList";
            this.lblGreskaBrisanje.Visible = false;
            // 
            // lblGreskaDanUNedelji
            // 
            this.lblGreskaDanUNedelji.AutoSize = true;
            this.lblGreskaDanUNedelji.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaDanUNedelji.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaDanUNedelji.Location = new System.Drawing.Point(815, 205);
            this.lblGreskaDanUNedelji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaDanUNedelji.Name = "lblGreskaDanUNedelji";
            this.lblGreskaDanUNedelji.Size = new System.Drawing.Size(54, 19);
            this.lblGreskaDanUNedelji.TabIndex = 14;
            this.lblGreskaDanUNedelji.Text = "label3";
            // 
            // lblGreskaTrajanje
            // 
            this.lblGreskaTrajanje.AutoSize = true;
            this.lblGreskaTrajanje.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaTrajanje.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaTrajanje.Location = new System.Drawing.Point(873, 145);
            this.lblGreskaTrajanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaTrajanje.Name = "lblGreskaTrajanje";
            this.lblGreskaTrajanje.Size = new System.Drawing.Size(54, 19);
            this.lblGreskaTrajanje.TabIndex = 13;
            this.lblGreskaTrajanje.Text = "label2";
            // 
            // lblGreskaOpisTreninga
            // 
            this.lblGreskaOpisTreninga.AutoSize = true;
            this.lblGreskaOpisTreninga.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaOpisTreninga.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaOpisTreninga.Location = new System.Drawing.Point(805, 373);
            this.lblGreskaOpisTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaOpisTreninga.Name = "lblGreskaOpisTreninga";
            this.lblGreskaOpisTreninga.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaOpisTreninga.TabIndex = 12;
            this.lblGreskaOpisTreninga.Text = "label1";
            // 
            // lblGreskaNazivTreninga
            // 
            this.lblGreskaNazivTreninga.AutoSize = true;
            this.lblGreskaNazivTreninga.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaNazivTreninga.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaNazivTreninga.Location = new System.Drawing.Point(805, 85);
            this.lblGreskaNazivTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreskaNazivTreninga.Name = "lblGreskaNazivTreninga";
            this.lblGreskaNazivTreninga.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaNazivTreninga.TabIndex = 11;
            this.lblGreskaNazivTreninga.Text = "label1";
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnDodajTrening.Location = new System.Drawing.Point(946, 395);
            this.btnDodajTrening.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(157, 52);
            this.btnDodajTrening.TabIndex = 10;
            this.btnDodajTrening.Text = "Dodaj Trening";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnObrisiTrening.Location = new System.Drawing.Point(620, 395);
            this.btnObrisiTrening.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(157, 52);
            this.btnObrisiTrening.TabIndex = 9;
            this.btnObrisiTrening.Text = "Obrisi trening";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            // 
            // cbDanUNedelji
            // 
            this.cbDanUNedelji.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.cbDanUNedelji.FormattingEnabled = true;
            this.cbDanUNedelji.Location = new System.Drawing.Point(809, 170);
            this.cbDanUNedelji.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanUNedelji.Name = "cbDanUNedelji";
            this.cbDanUNedelji.Size = new System.Drawing.Size(294, 33);
            this.cbDanUNedelji.TabIndex = 8;
            // 
            // txtOpisTreninga
            // 
            this.txtOpisTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtOpisTreninga.Location = new System.Drawing.Point(809, 233);
            this.txtOpisTreninga.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisTreninga.Multiline = true;
            this.txtOpisTreninga.Name = "txtOpisTreninga";
            this.txtOpisTreninga.Size = new System.Drawing.Size(294, 138);
            this.txtOpisTreninga.TabIndex = 7;
            // 
            // txtTrajanjeUMinutima
            // 
            this.txtTrajanjeUMinutima.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtTrajanjeUMinutima.Location = new System.Drawing.Point(873, 110);
            this.txtTrajanjeUMinutima.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrajanjeUMinutima.Name = "txtTrajanjeUMinutima";
            this.txtTrajanjeUMinutima.Size = new System.Drawing.Size(230, 33);
            this.txtTrajanjeUMinutima.TabIndex = 6;
            // 
            // txtNazivTreninga
            // 
            this.txtNazivTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNazivTreninga.Location = new System.Drawing.Point(809, 50);
            this.txtNazivTreninga.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivTreninga.Name = "txtNazivTreninga";
            this.txtNazivTreninga.Size = new System.Drawing.Size(294, 33);
            this.txtNazivTreninga.TabIndex = 5;
            // 
            // lblDanUNedelji
            // 
            this.lblDanUNedelji.AutoSize = true;
            this.lblDanUNedelji.Location = new System.Drawing.Point(614, 165);
            this.lblDanUNedelji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanUNedelji.Name = "lblDanUNedelji";
            this.lblDanUNedelji.Size = new System.Drawing.Size(191, 35);
            this.lblDanUNedelji.TabIndex = 4;
            this.lblDanUNedelji.Text = "Dan U Nedelji";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(614, 110);
            this.lblTrajanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(255, 35);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "TrajanjeUMinutima";
            // 
            // lblOpisTreninga
            // 
            this.lblOpisTreninga.AutoSize = true;
            this.lblOpisTreninga.Location = new System.Drawing.Point(614, 228);
            this.lblOpisTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisTreninga.Name = "lblOpisTreninga";
            this.lblOpisTreninga.Size = new System.Drawing.Size(187, 35);
            this.lblOpisTreninga.TabIndex = 2;
            this.lblOpisTreninga.Text = "Opis treninga";
            // 
            // lblNazivTreninga
            // 
            this.lblNazivTreninga.AutoSize = true;
            this.lblNazivTreninga.Location = new System.Drawing.Point(614, 45);
            this.lblNazivTreninga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivTreninga.Name = "lblNazivTreninga";
            this.lblNazivTreninga.Size = new System.Drawing.Size(196, 35);
            this.lblNazivTreninga.TabIndex = 1;
            this.lblNazivTreninga.Text = "NazivTreninga";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DarkRed;
            this.btnSacuvaj.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.btnSacuvaj.Location = new System.Drawing.Point(766, 733);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(370, 72);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sacuvaj program treninga";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnObrisi.Font = new System.Drawing.Font("Bahnschrift", 19.75F);
            this.btnObrisi.Location = new System.Drawing.Point(9, 734);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(370, 72);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi program treninga";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // lblGreskaNazivProgramaTreninga
            // 
            this.lblGreskaNazivProgramaTreninga.AutoSize = true;
            this.lblGreskaNazivProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaNazivProgramaTreninga.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaNazivProgramaTreninga.Location = new System.Drawing.Point(342, 146);
            this.lblGreskaNazivProgramaTreninga.Name = "lblGreskaNazivProgramaTreninga";
            this.lblGreskaNazivProgramaTreninga.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaNazivProgramaTreninga.TabIndex = 12;
            this.lblGreskaNazivProgramaTreninga.Text = "label1";
            this.lblGreskaNazivProgramaTreninga.Visible = false;
            // 
            // lblGreskaOpisProgramaTreninga
            // 
            this.lblGreskaOpisProgramaTreninga.AutoSize = true;
            this.lblGreskaOpisProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaOpisProgramaTreninga.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaOpisProgramaTreninga.Location = new System.Drawing.Point(342, 230);
            this.lblGreskaOpisProgramaTreninga.Name = "lblGreskaOpisProgramaTreninga";
            this.lblGreskaOpisProgramaTreninga.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaOpisProgramaTreninga.TabIndex = 13;
            this.lblGreskaOpisProgramaTreninga.Text = "label1";
            this.lblGreskaOpisProgramaTreninga.Visible = false;
            // 
            // lblGreskaBrojTreningaNedeljno
            // 
            this.lblGreskaBrojTreningaNedeljno.AutoSize = true;
            this.lblGreskaBrojTreningaNedeljno.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaBrojTreningaNedeljno.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaBrojTreningaNedeljno.Location = new System.Drawing.Point(928, 146);
            this.lblGreskaBrojTreningaNedeljno.Name = "lblGreskaBrojTreningaNedeljno";
            this.lblGreskaBrojTreningaNedeljno.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaBrojTreningaNedeljno.TabIndex = 14;
            this.lblGreskaBrojTreningaNedeljno.Text = "label1";
            this.lblGreskaBrojTreningaNedeljno.Visible = false;
            // 
            // lblGreskaCena
            // 
            this.lblGreskaCena.AutoSize = true;
            this.lblGreskaCena.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaCena.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaCena.Location = new System.Drawing.Point(714, 232);
            this.lblGreskaCena.Name = "lblGreskaCena";
            this.lblGreskaCena.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaCena.TabIndex = 15;
            this.lblGreskaCena.Text = "label1";
            this.lblGreskaCena.Visible = false;
            // 
            // UcKreirajProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
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
            this.Size = new System.Drawing.Size(1163, 884);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private Panel panel1;

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
