using Client.Communication;
using Client.UserControls;
using Common;
using Common.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class PrijavaGuiController
    {
        private UcPrijavaNaProgramTreninga ucPrijavaNaProgramTreninga;
        public Prijava prijava;
        private UcMojiProgramiTreninga ucMojiProgramiTreninga;
        internal Control KreirajUcPrijaviSeNaProgramTreninga(Korisnik ulogovaniKorisnik, ProgramTreninga pt)
        {
            ucPrijavaNaProgramTreninga = new UcPrijavaNaProgramTreninga();
            ucPrijavaNaProgramTreninga.TxtNazivProgramaTreninga.Text = pt.NazivProgramaTreninga;
            ucPrijavaNaProgramTreninga.TxtNazivKorisnika.Text = ulogovaniKorisnik.Ime + " " + ulogovaniKorisnik.Prezime;
            ucPrijavaNaProgramTreninga.TxtNazivProgramaTreninga.Enabled = false;
            ucPrijavaNaProgramTreninga.TxtNazivKorisnika.Enabled = false;
            ucPrijavaNaProgramTreninga.LblGreskaNapomena.Visible = false;


            ucPrijavaNaProgramTreninga.BtnPosaljiPrijavu.Click += (s, e) => PosaljiPrijavu(ulogovaniKorisnik, pt);

            return ucPrijavaNaProgramTreninga;
        }

        private void PosaljiPrijavu(Korisnik ulogovaniKorisnik, ProgramTreninga pt)
        {
            try
            {


                Prijava prijava = PokupiPodatkeOPrijavi(ulogovaniKorisnik, pt);

                if (ClientCommunication.Instance.VratiPrijavu(prijava) != null)
                {
                    MessageBox.Show("Već ste se prijavili na ovaj program treninga!");
                    MainCoordinator.Instance.PrikaziSveProgramTreningaKorisnik();
                    //throw new Exception("Već ste se prijavili na ovaj program treninga!");
                    return;
                }
                ClientCommunication.Instance.PosaljiPrijavu(prijava);
                MainCoordinator.Instance.PrikaziSveProgramTreningaKorisnik();
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

        private Prijava PokupiPodatkeOPrijavi(Korisnik ulogovaniKorisnik, ProgramTreninga pt)
        {

            if (ucPrijavaNaProgramTreninga.TxtNapomena.Text.Length >= 500)
            {
                ucPrijavaNaProgramTreninga.LblGreskaNapomena.Text = "Napomena ne sme da ima više od 500 karaktera";
                ucPrijavaNaProgramTreninga.LblGreskaNapomena.Visible = true;
                throw new UserException("userex >> napomena karakteri");
            }

            Prijava prijava = new Prijava()
            {
                ProgramTreninga = pt,
                Korisnik = ulogovaniKorisnik,
                DatumPrijave = DateTime.Now,
                Napomena = ucPrijavaNaProgramTreninga.TxtNapomena.Text,
                UplacenaClanarina = ucPrijavaNaProgramTreninga.CbClanarina.Checked
            };
            return prijava;
        }

        internal Control KreirajUcMojePrijave()
        {
            ucMojiProgramiTreninga = new UcMojiProgramiTreninga();
            BindingList<Prijava> prijave = new BindingList<Prijava>(ClientCommunication.Instance.VratiPrijaveZaKorisnika(MainCoordinator.Instance.ulogovaniKorisnik));
            ucMojiProgramiTreninga.dgvPrijave.DataSource = prijave;
            ucMojiProgramiTreninga.dgvPrijave.Columns["Korisnik"].Visible = false;
            ucMojiProgramiTreninga.dgvPrijave.Columns["UplacenaClanarina"].HeaderText = "Uplacena clanarina";
            if (prijave.Count == 0)
            {
                ucMojiProgramiTreninga.dgvPrijave.Visible = false;
                ucMojiProgramiTreninga.LblOdgovor.Visible = true;
            }
            else
            {
                ucMojiProgramiTreninga.dgvPrijave.Visible = true;
                ucMojiProgramiTreninga.LblOdgovor.Visible = false;
            }
            return ucMojiProgramiTreninga;
        }
    }
}
