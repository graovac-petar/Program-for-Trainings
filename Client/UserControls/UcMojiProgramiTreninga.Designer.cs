using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcMojiProgramiTreninga
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOdgovor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(413, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Moje Prijave";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 404);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.Location = new System.Drawing.Point(346, 245);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(199, 16);
            this.lblOdgovor.TabIndex = 2;
            this.lblOdgovor.Text = "Prijavite se na program treninga!";
            // 
            // UcMojiProgramiTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcMojiProgramiTreninga";
            this.Size = new System.Drawing.Size(966, 914);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOdgovor;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public DataGridView dgvPrijave { get => dataGridView1; set => dataGridView1 = value; }
        public Label LblOdgovor { get => lblOdgovor; set => lblOdgovor = value; }
    }
}
