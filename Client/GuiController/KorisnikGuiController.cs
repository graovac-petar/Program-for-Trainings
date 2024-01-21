using Client.Communication;
using Client.Forms;
using Common;
using Common.Model;
using System;

namespace Client.GuiController
{
    internal class KorisnikGuiController
    {
        public FrmPrijavljivanje frmPrijavljivanje;

        public KorisnikGuiController()
        {

        }

        public void KreirajFrmPrijavljivanje(FrmPrijavljivanje frmPrijavljivanje)
        {
            this.frmPrijavljivanje = frmPrijavljivanje;

            frmPrijavljivanje.Button1.Click += BtnPrijaviSeOnClick;
        }
        public void BtnPrijaviSeOnClick(object sender, EventArgs e)
        {
            try
            {
                Korisnik k = PreuzmiKorisnikPodatkeSaForme();
                k = ClientCommunication.Instance.PrijavljivanjeKorisnik(k);
                MainCoordinator.Instance.ulogovaniKorisnik = k;
                //MainCoordinator.Instance.PrikaziFrmKorisnik();


            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private Korisnik PreuzmiKorisnikPodatkeSaForme()
        {
            Korisnik k = new Korisnik()
            {
                Email = frmPrijavljivanje.TextBox1.Text,
                Sifra = frmPrijavljivanje.TextBox2.Text
            };
            return k;
        }
    }
}
