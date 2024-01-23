using Client.Communication;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmPrijavljivanje : Form
    {
        public FrmPrijavljivanje()
        {
            InitializeComponent();
        }

        private void FrmPrijavljivanje_Load(object sender, EventArgs e)
        {
            try
            {
                lblGreskaEmail.Visible = false;
                lblGreskaSifra.Visible = false;
                ClientCommunication.Instance.KonektujSeNaServer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
