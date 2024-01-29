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

            this.pretragaProgramaTreningaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.PrikaziSveProgramTreningaKorisnik();

            this.prijavaNaProgramTreningaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.PrikaziMojaPrijave();
        }

        internal void PromeniPanel(Control control)
        {
            pnlGlavna.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlGlavna.Controls.Add(control);
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainCoordinator.Instance.ulogovaniKorisnik != null)
                {
                    MainCoordinator.Instance.ulogovaniKorisnik = null;
                    ClientCommunication.instance.OdjaviSeKorisnik(MainCoordinator.Instance.ulogovaniKorisnik);
                }
                else if (MainCoordinator.Instance.ulogovaniAdministrator != null)
                {
                    MainCoordinator.Instance.ulogovaniAdministrator = null;
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
