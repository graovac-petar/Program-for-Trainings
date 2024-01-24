using Client.Communication;
using Client.GuiController;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmAdministrator : Form
    {
        public FrmAdministrator()
        {
            InitializeComponent();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                //sta ce nam ovo

                if (MainCoordinator.Instance.ulogovaniKorisnik != null)
                {
                    ClientCommunication.instance.OdjaviSeKorisnik(MainCoordinator.Instance.ulogovaniKorisnik);
                }
                else if (MainCoordinator.Instance.ulogovaniAdministrator != null)
                {
                    ClientCommunication.Instance.OdjaviSeAdministrator(MainCoordinator.Instance.ulogovaniAdministrator);
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
