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
            ClientCommunication.Instance.KonektujSeNaServer();
        }
    }
}
