using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            dgvClients.DataSource = ClientHandlers;
        }
        public BindingList<ClientHandler> ClientHandlers = new BindingList<ClientHandler>();

        private void btnPokreniServer_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!Server.Instance.pokrenutServer) Server.Instance.PokreniServer();
                btnPokreniServer.Enabled = false;
                btnZaustaviServer.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            Server.Instance.PokreniServer();
            btnPokreniServer.Enabled = false;

            Server.Instance.AddKlijenata = DodajKlijenta;
            Server.Instance.RemoveKlijenata = ObrisiKlijenta;
        }
        public void DodajKlijenta(ClientHandler ch)
        {
            Action a = () =>
            {
                ClientHandlers.Add(ch);
            };
            this.Invoke(a);
        }
        public void ObrisiKlijenta(ClientHandler ch)
        {
            Action a = () =>
            {
                ClientHandlers.Remove(ch);
            };
            this.Invoke(a);
        }
        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Server.Instance.pokrenutServer) Server.Instance.ZaustaviServer();
                btnPokreniServer.Enabled = true;
                btnZaustaviServer.Enabled = false;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
