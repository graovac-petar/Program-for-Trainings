namespace Client.UserControls
{
    partial class UcSingleTrening
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
            this.lblNazivTreninga = new System.Windows.Forms.Label();
            this.lblOpisTreninga = new System.Windows.Forms.Label();
            this.lblTrajanjeUMinutima = new System.Windows.Forms.Label();
            this.lblDanUnedelji = new System.Windows.Forms.Label();
            this.txtNazivTreninga = new System.Windows.Forms.TextBox();
            this.txtOpisTreninga = new System.Windows.Forms.TextBox();
            this.txtTrajanjeUMinutima = new System.Windows.Forms.TextBox();
            this.txtDanUNedelji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(173, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Izmeni Trening";
            // 
            // lblNazivTreninga
            // 
            this.lblNazivTreninga.AutoSize = true;
            this.lblNazivTreninga.Location = new System.Drawing.Point(95, 112);
            this.lblNazivTreninga.Name = "lblNazivTreninga";
            this.lblNazivTreninga.Size = new System.Drawing.Size(79, 13);
            this.lblNazivTreninga.TabIndex = 1;
            this.lblNazivTreninga.Text = "Naziv Treninga";
            // 
            // lblOpisTreninga
            // 
            this.lblOpisTreninga.AutoSize = true;
            this.lblOpisTreninga.Location = new System.Drawing.Point(95, 163);
            this.lblOpisTreninga.Name = "lblOpisTreninga";
            this.lblOpisTreninga.Size = new System.Drawing.Size(73, 13);
            this.lblOpisTreninga.TabIndex = 2;
            this.lblOpisTreninga.Text = "Opis Treninga";
            // 
            // lblTrajanjeUMinutima
            // 
            this.lblTrajanjeUMinutima.AutoSize = true;
            this.lblTrajanjeUMinutima.Location = new System.Drawing.Point(95, 212);
            this.lblTrajanjeUMinutima.Name = "lblTrajanjeUMinutima";
            this.lblTrajanjeUMinutima.Size = new System.Drawing.Size(98, 13);
            this.lblTrajanjeUMinutima.TabIndex = 3;
            this.lblTrajanjeUMinutima.Text = "Trajanje u minutima";
            // 
            // lblDanUnedelji
            // 
            this.lblDanUnedelji.AutoSize = true;
            this.lblDanUnedelji.Location = new System.Drawing.Point(95, 258);
            this.lblDanUnedelji.Name = "lblDanUnedelji";
            this.lblDanUnedelji.Size = new System.Drawing.Size(69, 13);
            this.lblDanUnedelji.TabIndex = 4;
            this.lblDanUnedelji.Text = "Dan u nedelji";
            // 
            // txtNazivTreninga
            // 
            this.txtNazivTreninga.Location = new System.Drawing.Point(242, 109);
            this.txtNazivTreninga.Name = "txtNazivTreninga";
            this.txtNazivTreninga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivTreninga.TabIndex = 5;
            // 
            // txtOpisTreninga
            // 
            this.txtOpisTreninga.Location = new System.Drawing.Point(242, 160);
            this.txtOpisTreninga.Name = "txtOpisTreninga";
            this.txtOpisTreninga.Size = new System.Drawing.Size(100, 20);
            this.txtOpisTreninga.TabIndex = 6;
            // 
            // txtTrajanjeUMinutima
            // 
            this.txtTrajanjeUMinutima.Location = new System.Drawing.Point(242, 205);
            this.txtTrajanjeUMinutima.Name = "txtTrajanjeUMinutima";
            this.txtTrajanjeUMinutima.Size = new System.Drawing.Size(100, 20);
            this.txtTrajanjeUMinutima.TabIndex = 7;
            // 
            // txtDanUNedelji
            // 
            this.txtDanUNedelji.Location = new System.Drawing.Point(242, 255);
            this.txtDanUNedelji.Name = "txtDanUNedelji";
            this.txtDanUNedelji.Size = new System.Drawing.Size(100, 20);
            this.txtDanUNedelji.TabIndex = 8;
            // 
            // UcSingleTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDanUNedelji);
            this.Controls.Add(this.txtTrajanjeUMinutima);
            this.Controls.Add(this.txtOpisTreninga);
            this.Controls.Add(this.txtNazivTreninga);
            this.Controls.Add(this.lblDanUnedelji);
            this.Controls.Add(this.lblTrajanjeUMinutima);
            this.Controls.Add(this.lblOpisTreninga);
            this.Controls.Add(this.lblNazivTreninga);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcSingleTrening";
            this.Size = new System.Drawing.Size(522, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNazivTreninga;
        private System.Windows.Forms.Label lblOpisTreninga;
        private System.Windows.Forms.Label lblTrajanjeUMinutima;
        private System.Windows.Forms.Label lblDanUnedelji;
        private System.Windows.Forms.TextBox txtNazivTreninga;
        private System.Windows.Forms.TextBox txtOpisTreninga;
        private System.Windows.Forms.TextBox txtTrajanjeUMinutima;
        private System.Windows.Forms.TextBox txtDanUNedelji;
    }
}
