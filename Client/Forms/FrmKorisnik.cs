using Client.Communication;
using Client.GuiController;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmKorisnik : Form
    {
        public FrmKorisnik()
        {
            InitializeComponent();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;


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
