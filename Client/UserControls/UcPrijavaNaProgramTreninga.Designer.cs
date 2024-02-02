using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UcPrijavaNaProgramTreninga
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
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.txtNazivProgramaTreninga = new System.Windows.Forms.TextBox();
            this.txtNazivKorisnika = new System.Windows.Forms.TextBox();
            this.cbClanarina = new System.Windows.Forms.CheckBox();
            this.lblClanarina = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnPosaljiPrijavu = new System.Windows.Forms.Button();
            this.pnlPictureBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGreskaNapomena = new System.Windows.Forms.Label();
            this.pnlPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.lblTitle.Location = new System.Drawing.Point(307, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Prijava na program treninga";
            // 
            // lblNazivProgramaTreninga
            // 
            this.lblNazivProgramaTreninga.AutoSize = true;
            this.lblNazivProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblNazivProgramaTreninga.Location = new System.Drawing.Point(30, 105);
            this.lblNazivProgramaTreninga.Name = "lblNazivProgramaTreninga";
            this.lblNazivProgramaTreninga.Size = new System.Drawing.Size(332, 35);
            this.lblNazivProgramaTreninga.TabIndex = 1;
            this.lblNazivProgramaTreninga.Text = "Naziv ProgramaTreninga";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblKorisnik.Location = new System.Drawing.Point(636, 110);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(212, 35);
            this.lblKorisnik.TabIndex = 2;
            this.lblKorisnik.Text = "Naziv korisnika";
            // 
            // txtNazivProgramaTreninga
            // 
            this.txtNazivProgramaTreninga.AcceptsTab = true;
            this.txtNazivProgramaTreninga.Enabled = false;
            this.txtNazivProgramaTreninga.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNazivProgramaTreninga.Location = new System.Drawing.Point(368, 110);
            this.txtNazivProgramaTreninga.Name = "txtNazivProgramaTreninga";
            this.txtNazivProgramaTreninga.Size = new System.Drawing.Size(247, 33);
            this.txtNazivProgramaTreninga.TabIndex = 5;
            // 
            // txtNazivKorisnika
            // 
            this.txtNazivKorisnika.Enabled = false;
            this.txtNazivKorisnika.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNazivKorisnika.Location = new System.Drawing.Point(854, 110);
            this.txtNazivKorisnika.Name = "txtNazivKorisnika";
            this.txtNazivKorisnika.Size = new System.Drawing.Size(278, 33);
            this.txtNazivKorisnika.TabIndex = 6;
            // 
            // cbClanarina
            // 
            this.cbClanarina.AutoSize = true;
            this.cbClanarina.Location = new System.Drawing.Point(902, 181);
            this.cbClanarina.Name = "cbClanarina";
            this.cbClanarina.Size = new System.Drawing.Size(15, 14);
            this.cbClanarina.TabIndex = 7;
            this.cbClanarina.UseVisualStyleBackColor = true;
            // 
            // lblClanarina
            // 
            this.lblClanarina.AutoSize = true;
            this.lblClanarina.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblClanarina.Location = new System.Drawing.Point(636, 171);
            this.lblClanarina.Name = "lblClanarina";
            this.lblClanarina.Size = new System.Drawing.Size(260, 35);
            this.lblClanarina.TabIndex = 8;
            this.lblClanarina.Text = "Uplacena clanarina";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Font = new System.Drawing.Font("Bahnschrift", 21.75F);
            this.lblNapomena.Location = new System.Drawing.Point(26, 176);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(154, 35);
            this.lblNapomena.TabIndex = 9;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.txtNapomena.Location = new System.Drawing.Point(186, 181);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(429, 143);
            this.txtNapomena.TabIndex = 10;
            // 
            // btnPosaljiPrijavu
            // 
            this.btnPosaljiPrijavu.BackColor = System.Drawing.Color.DarkRed;
            this.btnPosaljiPrijavu.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnPosaljiPrijavu.Location = new System.Drawing.Point(820, 255);
            this.btnPosaljiPrijavu.Name = "btnPosaljiPrijavu";
            this.btnPosaljiPrijavu.Size = new System.Drawing.Size(312, 69);
            this.btnPosaljiPrijavu.TabIndex = 11;
            this.btnPosaljiPrijavu.Text = "Posalji Prijavu";
            this.btnPosaljiPrijavu.UseVisualStyleBackColor = false;
            // 
            // pnlPictureBox
            // 
            this.pnlPictureBox.Controls.Add(this.pictureBox1);
            this.pnlPictureBox.Location = new System.Drawing.Point(3, 370);
            this.pnlPictureBox.Name = "pnlPictureBox";
            this.pnlPictureBox.Size = new System.Drawing.Size(1212, 611);
            this.pnlPictureBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Client.Properties.Resources.mot;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 611);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreskaNapomena
            // 
            this.lblGreskaNapomena.AutoSize = true;
            this.lblGreskaNapomena.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblGreskaNapomena.ForeColor = System.Drawing.Color.Red;
            this.lblGreskaNapomena.Location = new System.Drawing.Point(182, 336);
            this.lblGreskaNapomena.Name = "lblGreskaNapomena";
            this.lblGreskaNapomena.Size = new System.Drawing.Size(51, 19);
            this.lblGreskaNapomena.TabIndex = 14;
            this.lblGreskaNapomena.Text = "label1";
            // 
            // UcPrijavaNaProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.lblGreskaNapomena);
            this.Controls.Add(this.pnlPictureBox);
            this.Controls.Add(this.btnPosaljiPrijavu);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblClanarina);
            this.Controls.Add(this.cbClanarina);
            this.Controls.Add(this.txtNazivKorisnika);
            this.Controls.Add(this.txtNazivProgramaTreninga);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblNazivProgramaTreninga);
            this.Controls.Add(this.lblTitle);
            this.Name = "UcPrijavaNaProgramTreninga";
            this.Size = new System.Drawing.Size(1163, 884);
            this.pnlPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNazivProgramaTreninga;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.TextBox txtNazivProgramaTreninga;
        private System.Windows.Forms.TextBox txtNazivKorisnika;
        private System.Windows.Forms.CheckBox cbClanarina;
        private System.Windows.Forms.Label lblClanarina;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnPosaljiPrijavu;
        private Panel pnlPictureBox;
        private PictureBox pictureBox1;
        private Label lblGreskaNapomena;

        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblNazivProgramaTreninga { get => lblNazivProgramaTreninga; set => lblNazivProgramaTreninga = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public TextBox TxtNazivProgramaTreninga { get => txtNazivProgramaTreninga; set => txtNazivProgramaTreninga = value; }
        public TextBox TxtNazivKorisnika { get => txtNazivKorisnika; set => txtNazivKorisnika = value; }
        public CheckBox CbClanarina { get => cbClanarina; set => cbClanarina = value; }
        public Label LblClanarina { get => lblClanarina; set => lblClanarina = value; }
        public Label LblNapomena { get => lblNapomena; set => lblNapomena = value; }
        public TextBox TxtNapomena { get => txtNapomena; set => txtNapomena = value; }
        public Button BtnPosaljiPrijavu { get => btnPosaljiPrijavu; set => btnPosaljiPrijavu = value; }
        public Label LblGreskaNapomena { get => lblGreskaNapomena; set => lblGreskaNapomena = value; }
    }
}
