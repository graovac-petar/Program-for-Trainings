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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(303, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pregled Programa Treninga";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(67, 158);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(161, 16);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv Programa Treninga";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(293, 158);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(249, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtBrojTreninga
            // 
            this.txtBrojTreninga.Location = new System.Drawing.Point(293, 217);
            this.txtBrojTreninga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrojTreninga.Name = "txtBrojTreninga";
            this.txtBrojTreninga.Size = new System.Drawing.Size(133, 22);
            this.txtBrojTreninga.TabIndex = 4;
            // 
            // lblBrojTreninga
            // 
            this.lblBrojTreninga.AutoSize = true;
            this.lblBrojTreninga.Location = new System.Drawing.Point(67, 220);
            this.lblBrojTreninga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojTreninga.Name = "lblBrojTreninga";
            this.lblBrojTreninga.Size = new System.Drawing.Size(146, 16);
            this.lblBrojTreninga.TabIndex = 3;
            this.lblBrojTreninga.Text = "Broj Treninga Nedeljno";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(293, 274);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(133, 22);
            this.txtCena.TabIndex = 6;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(67, 278);
            this.lblCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(39, 16);
            this.lblCena.TabIndex = 5;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(67, 327);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(154, 16);
            this.lblOpis.TabIndex = 7;
            this.lblOpis.Text = "Opis programa Treninga";
            // 
            // txtOpisProgramaTreninga
            // 
            this.txtOpisProgramaTreninga.Location = new System.Drawing.Point(293, 327);
            this.txtOpisProgramaTreninga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOpisProgramaTreninga.Name = "txtOpisProgramaTreninga";
            this.txtOpisProgramaTreninga.Size = new System.Drawing.Size(249, 22);
            this.txtOpisProgramaTreninga.TabIndex = 8;
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(71, 426);
            this.dgvTreninzi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.Size = new System.Drawing.Size(837, 284);
            this.dgvTreninzi.TabIndex = 11;
            // 
            // lblListaTreninga
            // 
            this.lblListaTreninga.AutoSize = true;
            this.lblListaTreninga.Location = new System.Drawing.Point(73, 391);
            this.lblListaTreninga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaTreninga.Name = "lblListaTreninga";
            this.lblListaTreninga.Size = new System.Drawing.Size(92, 16);
            this.lblListaTreninga.TabIndex = 12;
            this.lblListaTreninga.Text = "Lista Treninga";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(633, 361);
            this.btnPrijaviSe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(275, 47);
            this.btnPrijaviSe.TabIndex = 17;
            this.btnPrijaviSe.Text = "Prijavi se na program treninga";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // UcSingleProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblListaTreninga);
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.txtOpisProgramaTreninga);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtBrojTreninga);
            this.Controls.Add(this.lblBrojTreninga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcSingleProgramTreninga";
            this.Size = new System.Drawing.Size(957, 1147);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
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
