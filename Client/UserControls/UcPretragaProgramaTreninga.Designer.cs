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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramaTreninga)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProgramTreninga
            // 
            this.lblProgramTreninga.AutoSize = true;
            this.lblProgramTreninga.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblProgramTreninga.Location = new System.Drawing.Point(453, 15);
            this.lblProgramTreninga.Name = "lblProgramTreninga";
            this.lblProgramTreninga.Size = new System.Drawing.Size(320, 58);
            this.lblProgramTreninga.TabIndex = 0;
            this.lblProgramTreninga.Text = "Programi Treninga";
            // 
            // dgvListaProgramaTreninga
            // 
            this.dgvListaProgramaTreninga.AllowUserToAddRows = false;
            this.dgvListaProgramaTreninga.AllowUserToDeleteRows = false;
            this.dgvListaProgramaTreninga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProgramaTreninga.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaProgramaTreninga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProgramaTreninga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProgramaTreninga.Location = new System.Drawing.Point(0, 0);
            this.dgvListaProgramaTreninga.Name = "dgvListaProgramaTreninga";
            this.dgvListaProgramaTreninga.ReadOnly = true;
            this.dgvListaProgramaTreninga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProgramaTreninga.Size = new System.Drawing.Size(1141, 476);
            this.dgvListaProgramaTreninga.TabIndex = 1;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Bahnschrift", 16.75F);
            this.txtPretraga.Location = new System.Drawing.Point(134, 687);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(342, 34);
            this.txtPretraga.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblIme.Location = new System.Drawing.Point(128, 640);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(334, 35);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime Programa Treninga :";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.DarkRed;
            this.btnIzaberi.Font = new System.Drawing.Font("Bahnschrift", 17.75F);
            this.btnIzaberi.Location = new System.Drawing.Point(793, 655);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(308, 95);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi program treninga";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Bahnschrift", 19.75F);
            this.lblGreska.ForeColor = System.Drawing.Color.Red;
            this.lblGreska.Location = new System.Drawing.Point(3, 569);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(83, 33);
            this.lblGreska.TabIndex = 6;
            this.lblGreska.Text = "label1";
            this.lblGreska.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaProgramaTreninga);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 19F);
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 476);
            this.panel1.TabIndex = 7;
            // 
            // UcPretragaProgramaTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblProgramTreninga);
            this.Name = "UcPretragaProgramaTreninga";
            this.Size = new System.Drawing.Size(1163, 884);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramaTreninga)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramTreninga;
        private System.Windows.Forms.DataGridView dgvListaProgramaTreninga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnIzaberi;
        private Label lblGreska;
        private Panel panel1;

        public Label LblProgramTreninga { get => lblProgramTreninga; set => lblProgramTreninga = value; }
        public DataGridView DgvListaProgramaTreninga { get => dgvListaProgramaTreninga; set => dgvListaProgramaTreninga = value; }
        //public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
    }
}
