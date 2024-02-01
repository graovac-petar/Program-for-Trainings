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
            programTreningaGuiController = new ProgramTreningaGuiController();
            prijavaGuiController = new PrijavaGuiController();
            grupaGuiController = new GrupaGuiController();
        }
        //Kontroleri
        private KorisnikGuiController korisnikGuiController;
        private PrijavaGuiController prijavaGuiController;
        private GrupaGuiController grupaGuiController;
        private ProgramTreningaGuiController programTreningaGuiController;

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

        internal void PrikaziSveProgramTreningaKorisnik()
        {
            frmKorisnik.PromeniPanel(programTreningaGuiController.KreirajUcPrikazProgramaTreninga(FormMode.ChooseKorisnik));
        }
        internal void PrikaziSveProgramTreningaAdministrator()
        {
            frmAdministrator.PromeniPanel(programTreningaGuiController.KreirajUcPrikazProgramaTreninga(FormMode.ChooseAdmin));
        }

        internal void PrikaziPodatkeOProgramuTreningaKorisnik(ProgramTreninga pt)
        {
            frmKorisnik.PromeniPanel(programTreningaGuiController.KreirajUcPrikaziProgramTreninga(FormMode.ChooseKorisnik, pt));
        }

        internal void PrikaziKreirajPrijavuNaProgramTreninga(ProgramTreninga pt)
        {
            frmKorisnik.PromeniPanel(prijavaGuiController.KreirajUcPrijaviSeNaProgramTreninga(ulogovaniKorisnik, pt));
        }

        internal void PrikaziMojaPrijave()
        {
            frmKorisnik.PromeniPanel(prijavaGuiController.KreirajUcMojePrijave());
        }

        internal void PrikaziPodatkeOProgramuTreningaAdministrator(ProgramTreninga pt)
        {
            frmAdministrator.PromeniPanel(programTreningaGuiController.KreirajUcIzmenaProgramTreninga(FormMode.Edit, pt));
        }

        internal void NapraviProgramTreningaAdministrator()
        {
            frmAdministrator.PromeniPanel(programTreningaGuiController.KreirajUcIzmenaProgramTreninga(FormMode.Add, null));
        }

        internal void PrikaziSveGrupeAdministrator()
        {
            frmAdministrator.PromeniPanel(grupaGuiController.KreirajUcPrikazGrupaAdministrator());
        }

        internal void PrikaziPodatkeOgrupi(Grupa g)
        {
            frmAdministrator.PromeniPanel(grupaGuiController.KreirajUcPrikazGrupe(FormMode.Edit, g));
        }

        internal void NapraviGrupuAdministrator()
        {
            frmAdministrator.PromeniPanel(grupaGuiController.KreirajUcPrikazGrupe(FormMode.Add, null));
        }
    }
}
