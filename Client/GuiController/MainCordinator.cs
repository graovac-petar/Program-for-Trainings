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

        //Forme
        public FrmPrijavljivanje frmPrijavljivanje;

        internal void KreirajPrijavu()
        {
            korisnikGuiController.KreirajFrmPrijavljivanje(this.frmPrijavljivanje);
        }
    }
}
