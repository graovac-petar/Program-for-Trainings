using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcPretragaProgramaTreninga
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
            this.lblProgramTreninga = new System.Windows.Forms.Label();
            this.dgvListaProgramaTreninga = new System.Windows.Forms.DataGridView();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramaTreninga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramTreninga
            // 
            this.lblProgramTreninga.AutoSize = true;
            this.lblProgramTreninga.Location = new System.Drawing.Point(452, 65);
            this.lblProgramTreninga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramTreninga.Name = "lblProgramTreninga";
            this.lblProgramTreninga.Size = new System.Drawing.Size(119, 16);
            this.lblProgramTreninga.TabIndex = 0;
            this.lblProgramTreninga.Text = "Programi Treninga";
            // 
            // dgvListaProgramaTreninga
            // 
            this.dgvListaProgramaTreninga.AllowUserToAddRows = false;
            this.dgvListaProgramaTreninga.AllowUserToDeleteRows = false;
            this.dgvListaProgramaTreninga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProgramaTreninga.Location = new System.Drawing.Point(33, 134);
            this.dgvListaProgramaTreninga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaProgramaTreninga.Name = "dgvListaProgramaTreninga";
            this.dgvListaProgramaTreninga.ReadOnly = true;
            this.dgvListaProgramaTreninga.Size = new System.Drawing.Size(1032, 514);
            this.dgvListaProgramaTreninga.TabIndex = 1;
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(295, 695);
            this.lblPretrazi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(52, 16);
            this.lblPretrazi.TabIndex = 2;
            this.lblPretrazi.Text = "Pretrazi";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(200, 730);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(261, 22);
            this.txtPretraga.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(40, 734);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(146, 16);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime ProgramaTreninga";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(850, 678);
            this.btnIzaberi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(215, 74);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi program treninga";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Location = new System.Drawing.Point(40, 665);
            this.lblGreska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(44, 16);
            this.lblGreska.TabIndex = 6;
            this.lblGreska.Text = "label1";
            // 
            // UcPretragaProgramaTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.dgvListaProgramaTreninga);
            this.Controls.Add(this.lblProgramTreninga);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcPretragaProgramaTreninga";
            this.Size = new System.Drawing.Size(1107, 812);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramaTreninga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramTreninga;
        private System.Windows.Forms.DataGridView dgvListaProgramaTreninga;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnIzaberi;
        private Label lblGreska;

        public Label LblProgramTreninga { get => lblProgramTreninga; set => lblProgramTreninga = value; }
        public DataGridView DgvListaProgramaTreninga { get => dgvListaProgramaTreninga; set => dgvListaProgramaTreninga = value; }
        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
    }
}
