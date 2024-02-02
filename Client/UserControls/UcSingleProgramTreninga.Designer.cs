using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcSingleProgramTreninga
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBrojTreninga = new System.Windows.Forms.TextBox();
            this.lblBrojTreninga = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpisProgramaTreninga = new System.Windows.Forms.TextBox();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.lblListaTreninga = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblTitle.Location = new System.Drawing.Point(371, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pregled Programa Treninga";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblNaziv.Location = new System.Drawing.Point(163, 150);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(341, 35);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv Programa Treninga";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNaziv.Location = new System.Drawing.Point(510, 150);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(506, 33);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtBrojTreninga
            // 
            this.txtBrojTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtBrojTreninga.Location = new System.Drawing.Point(510, 231);
            this.txtBrojTreninga.Name = "txtBrojTreninga";
            this.txtBrojTreninga.Size = new System.Drawing.Size(506, 33);
            this.txtBrojTreninga.TabIndex = 4;
            // 
            // lblBrojTreninga
            // 
            this.lblBrojTreninga.AutoSize = true;
            this.lblBrojTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblBrojTreninga.Location = new System.Drawing.Point(163, 226);
            this.lblBrojTreninga.Name = "lblBrojTreninga";
            this.lblBrojTreninga.Size = new System.Drawing.Size(313, 35);
            this.lblBrojTreninga.TabIndex = 3;
            this.lblBrojTreninga.Text = "Broj Treninga Nedeljno";
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtCena.Location = new System.Drawing.Point(510, 305);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(506, 33);
            this.txtCena.TabIndex = 6;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblCena.Location = new System.Drawing.Point(163, 300);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(80, 35);
            this.lblCena.TabIndex = 5;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblOpis.Location = new System.Drawing.Point(163, 370);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(326, 35);
            this.lblOpis.TabIndex = 7;
            this.lblOpis.Text = "Opis programa Treninga";
            // 
            // txtOpisProgramaTreninga
            // 
            this.txtOpisProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtOpisProgramaTreninga.Location = new System.Drawing.Point(510, 375);
            this.txtOpisProgramaTreninga.Multiline = true;
            this.txtOpisProgramaTreninga.Name = "txtOpisProgramaTreninga";
            this.txtOpisProgramaTreninga.Size = new System.Drawing.Size(506, 96);
            this.txtOpisProgramaTreninga.TabIndex = 8;
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AllowUserToOrderColumns = true;
            this.dgvTreninzi.AllowUserToResizeColumns = false;
            this.dgvTreninzi.AllowUserToResizeRows = false;
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreninzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreninzi.Location = new System.Drawing.Point(0, 0);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(847, 224);
            this.dgvTreninzi.TabIndex = 11;
            // 
            // lblListaTreninga
            // 
            this.lblListaTreninga.AutoSize = true;
            this.lblListaTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblListaTreninga.Location = new System.Drawing.Point(163, 436);
            this.lblListaTreninga.Name = "lblListaTreninga";
            this.lblListaTreninga.Size = new System.Drawing.Size(197, 35);
            this.lblListaTreninga.TabIndex = 12;
            this.lblListaTreninga.Text = "Lista Treninga";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnPrijaviSe.Location = new System.Drawing.Point(467, 735);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(259, 68);
            this.btnPrijaviSe.TabIndex = 17;
            this.btnPrijaviSe.Text = "Prijavi se na program treninga";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTreninzi);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.panel1.Location = new System.Drawing.Point(169, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 224);
            this.panel1.TabIndex = 18;
            // 
            // UcSingleProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblListaTreninga);
            this.Controls.Add(this.txtOpisProgramaTreninga);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtBrojTreninga);
            this.Controls.Add(this.lblBrojTreninga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcSingleProgramTreninga";
            this.Size = new System.Drawing.Size(1163, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBrojTreninga;
        private System.Windows.Forms.Label lblBrojTreninga;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpisProgramaTreninga;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.Label lblListaTreninga;
        private Button btnPrijaviSe;
        private Panel panel1;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtBrojTreninga { get => txtBrojTreninga; set => txtBrojTreninga = value; }
        public Label LblBrojTreninga { get => lblBrojTreninga; set => lblBrojTreninga = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public TextBox TxtOpisProgramaTreninga { get => txtOpisProgramaTreninga; set => txtOpisProgramaTreninga = value; }
        public DataGridView DgvTreninzi { get => dgvTreninzi; set => dgvTreninzi = value; }
        public Label LblListaTreninga { get => lblListaTreninga; set => lblListaTreninga = value; }
        public Button BtnPrijaviSe { get => btnPrijaviSe; set => btnPrijaviSe = value; }
    }
}
