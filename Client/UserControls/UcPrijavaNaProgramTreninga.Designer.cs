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
            this.lblGreskaNapomena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(265, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Prijava na program treninga";
            // 
            // lblNazivProgramaTreninga
            // 
            this.lblNazivProgramaTreninga.AutoSize = true;
            this.lblNazivProgramaTreninga.Location = new System.Drawing.Point(106, 122);
            this.lblNazivProgramaTreninga.Name = "lblNazivProgramaTreninga";
            this.lblNazivProgramaTreninga.Size = new System.Drawing.Size(124, 13);
            this.lblNazivProgramaTreninga.TabIndex = 1;
            this.lblNazivProgramaTreninga.Text = "Naziv ProgramaTreninga";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(393, 125);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(79, 13);
            this.lblKorisnik.TabIndex = 2;
            this.lblKorisnik.Text = "Naziv korisnika";
            // 
            // txtNazivProgramaTreninga
            // 
            this.txtNazivProgramaTreninga.AcceptsTab = true;
            this.txtNazivProgramaTreninga.Enabled = false;
            this.txtNazivProgramaTreninga.Location = new System.Drawing.Point(250, 122);
            this.txtNazivProgramaTreninga.Name = "txtNazivProgramaTreninga";
            this.txtNazivProgramaTreninga.Size = new System.Drawing.Size(100, 20);
            this.txtNazivProgramaTreninga.TabIndex = 5;
            // 
            // txtNazivKorisnika
            // 
            this.txtNazivKorisnika.Enabled = false;
            this.txtNazivKorisnika.Location = new System.Drawing.Point(492, 122);
            this.txtNazivKorisnika.Name = "txtNazivKorisnika";
            this.txtNazivKorisnika.Size = new System.Drawing.Size(100, 20);
            this.txtNazivKorisnika.TabIndex = 6;
            // 
            // cbClanarina
            // 
            this.cbClanarina.AutoSize = true;
            this.cbClanarina.Location = new System.Drawing.Point(511, 173);
            this.cbClanarina.Name = "cbClanarina";
            this.cbClanarina.Size = new System.Drawing.Size(15, 14);
            this.cbClanarina.TabIndex = 7;
            this.cbClanarina.UseVisualStyleBackColor = true;
            // 
            // lblClanarina
            // 
            this.lblClanarina.AutoSize = true;
            this.lblClanarina.Location = new System.Drawing.Point(393, 173);
            this.lblClanarina.Name = "lblClanarina";
            this.lblClanarina.Size = new System.Drawing.Size(99, 13);
            this.lblClanarina.TabIndex = 8;
            this.lblClanarina.Text = "Uplacena clanarina";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(106, 174);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 9;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(186, 170);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(164, 20);
            this.txtNapomena.TabIndex = 10;
            // 
            // btnPosaljiPrijavu
            // 
            this.btnPosaljiPrijavu.Location = new System.Drawing.Point(396, 229);
            this.btnPosaljiPrijavu.Name = "btnPosaljiPrijavu";
            this.btnPosaljiPrijavu.Size = new System.Drawing.Size(170, 42);
            this.btnPosaljiPrijavu.TabIndex = 11;
            this.btnPosaljiPrijavu.Text = "Posalji Prijavu";
            this.btnPosaljiPrijavu.UseVisualStyleBackColor = true;
            // 
            // lblGreskaNapomena
            // 
            this.lblGreskaNapomena.AutoSize = true;
            this.lblGreskaNapomena.Location = new System.Drawing.Point(195, 205);
            this.lblGreskaNapomena.Name = "lblGreskaNapomena";
            this.lblGreskaNapomena.Size = new System.Drawing.Size(35, 13);
            this.lblGreskaNapomena.TabIndex = 12;
            this.lblGreskaNapomena.Text = "label1";
            // 
            // UcPrijavaNaProgramTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreskaNapomena);
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
            this.Size = new System.Drawing.Size(708, 708);
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
