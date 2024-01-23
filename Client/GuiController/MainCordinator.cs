using Client.Forms;
using Common.Model;

namespace Client.GuiController
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null) instance = new MainCoordinator();
                return instance;
            }
        }
        private MainCoordinator()
        {
            //ovde se inicijalizuju svi kontroleri
            korisnikGuiController = new KorisnikGuiController();
            //kursGuiController = new KursGuiController();
            //prijavaNaKursGuiController = new PrijavaNaKursGuiController();
            //grupaGuiController = new GrupaGuiController();
        }
        //Kontroleri
        private KorisnikGuiController korisnikGuiController;

        //Ulogovani
        public Korisnik ulogovaniKorisnik;
        public Administrator ulogovaniAdministrator;

        //Forme
        public FrmPrijavljivanje frmPrijavljivanje;
        public FrmRegistracija frmRegistracija;
        public FrmKorisnik frmKorisnik;
        public FrmAdministrator frmAdministrator;

        internal void KreirajPrijavu()
        {
            korisnikGuiController.KreirajFrmPrijavljivanje(this.frmPrijavljivanje);
        }

        internal void PrikaziFrmKorisnik()
        {
            frmPrijavljivanje.Visible = false;
            frmKorisnik = new FrmKorisnik();
            frmKorisnik.ShowDialog();
            frmPrijavljivanje.Visible = true;
        }

        internal void PrikaziFrmAdministrator()
        {
            frmPrijavljivanje.Visible = false;
            frmAdministrator = new FrmAdministrator();
            frmAdministrator.ShowDialog();
            frmPrijavljivanje.Visible = true;
        }
    }
}
