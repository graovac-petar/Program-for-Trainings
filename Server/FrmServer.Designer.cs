namespace Server
{
    partial class FrmServer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.btnZaustaviServer = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.Location = new System.Drawing.Point(163, 342);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(201, 80);
            this.btnPokreniServer.TabIndex = 0;
            this.btnPokreniServer.Text = "Pokreni Server";
            this.btnPokreniServer.UseVisualStyleBackColor = true;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.Location = new System.Drawing.Point(431, 342);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(201, 80);
            this.btnZaustaviServer.TabIndex = 1;
            this.btnZaustaviServer.Text = "Zaustavi Server";
            this.btnZaustaviServer.UseVisualStyleBackColor = true;
            this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(163, 58);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(469, 253);
            this.dgvClients.TabIndex = 2;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.btnPokreniServer);
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPokreniServer;
        private System.Windows.Forms.Button btnZaustaviServer;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}

