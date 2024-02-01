using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcPretragaGrupa
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
            this.dgvListaGrupa = new System.Windows.Forms.DataGridView();
            this.lblGreska = new System.Windows.Forms.Label();
            this.lblImeGrupe = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.btnIzaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGrupa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(380, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Grupe";
            // 
            // dgvListaGrupa
            // 
            this.dgvListaGrupa.AllowUserToAddRows = false;
            this.dgvListaGrupa.AllowUserToDeleteRows = false;
            this.dgvListaGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGrupa.Location = new System.Drawing.Point(33, 103);
            this.dgvListaGrupa.Name = "dgvListaGrupa";
            this.dgvListaGrupa.ReadOnly = true;
            this.dgvListaGrupa.Size = new System.Drawing.Size(762, 423);
            this.dgvListaGrupa.TabIndex = 2;
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Location = new System.Drawing.Point(78, 541);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(35, 13);
            this.lblGreska.TabIndex = 3;
            this.lblGreska.Text = "label1";
            // 
            // lblImeGrupe
            // 
            this.lblImeGrupe.AutoSize = true;
            this.lblImeGrupe.Location = new System.Drawing.Point(30, 589);
            this.lblImeGrupe.Name = "lblImeGrupe";
            this.lblImeGrupe.Size = new System.Drawing.Size(64, 13);
            this.lblImeGrupe.TabIndex = 4;
            this.lblImeGrupe.Text = "Naziv grupe";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(114, 586);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(213, 20);
            this.txtPretraga.TabIndex = 5;
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(191, 566);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(42, 13);
            this.lblPretrazi.TabIndex = 6;
            this.lblPretrazi.Text = "Pretrazi";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(647, 556);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(148, 50);
            this.btnIzaberi.TabIndex = 7;
            this.btnIzaberi.Text = "Izaberi grupu";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // UcPretragaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblImeGrupe);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.dgvListaGrupa);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcPretragaGrupa";
            this.Size = new System.Drawing.Size(823, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGrupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvListaGrupa;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label lblImeGrupe;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.Button btnIzaberi;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public DataGridView DgvListaGrupa { get => dgvListaGrupa; set => dgvListaGrupa = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
        public Label LblImeGrupe { get => lblImeGrupe; set => lblImeGrupe = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
    }
}
