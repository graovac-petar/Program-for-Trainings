using Client.Communication;
using Client.Forms;
using Common;
using Common.Model;
using System;
using System.Linq;

namespace Client.GuiController
{
    internal class KorisnikGuiController
    {
        public FrmPrijavljivanje frmPrijavljivanje;
        public FrmRegistracija frmRegistracija;

        public KorisnikGuiController()
        {

        }

        public void KreirajFrmPrijavljivanje(FrmPrijavljivanje frmPrijavljivanje)
        {
            this.frmPrijavljivanje = frmPrijavljivanje;

            frmPrijavljivanje.BtnPrijaviSe.Click += BtnPrijaviSeOnClick;
            frmPrijavljivanje.LblRegistrujSe.Click += LblRegistrujSeOnClick;
        }

        private void LblRegistrujSeOnClick(object sender, EventArgs e)
        {
            frmRegistracija = new FrmRegistracija();
            MainCoordinator.Instance.frmRegistracija = frmRegistracija;
            frmRegistracija.BtnRegistracija.Click += BtnRegistrujSeOnClick;
            frmRegistracija.ShowDialog();
        }

        private void BtnRegistrujSeOnClick(object sender, EventArgs e)
        {
            try
            {
                frmRegistracija.LblGreskaIme.Visible = false;
                frmRegistracija.LblGreskaPrezime.Visible = false;
                frmRegistracija.LblGreskaDatum.Visible = false;
                frmRegistracija.LblGreskaKontakt.Visible = false;
                frmRegistracija.LblGreskaEmail.Visible = false;
                frmRegistracija.LblGreskaSifra.Visible = false;

                //prazna polja
                if (frmRegistracija.TxtIme.Text == "")
                {
                    frmRegistracija.LblGreskaIme.Text = "Morate uneti ime";
                    frmRegistracija.LblGreskaIme.Visible = true;
                    throw new UserException("userex >> ime");
                }
                if (frmRegistracija.TxtPrezime.Text == "")
                {
                    frmRegistracija.LblGreskaPrezime.Text = "Morate uneti prezime";
                    frmRegistracija.LblGreskaPrezime.Visible = true;
                    throw new UserException("userex >> prezime");
                }
                if (frmRegistracija.DtpDatumRodjenja.Value == null)
                {
                    frmRegistracija.LblGreskaDatum.Text = "Morate uneti datum";
                    frmRegistracija.LblGreskaDatum.Visible = true;
                    throw new UserException("userex >> datum");
                }
                if (frmRegistracija.TxtKontakt.Text == "")
                {
                    frmRegistracija.LblGreskaKontakt.Text = "Morate uneti kontakt telefon";
                    frmRegistracija.LblGreskaKontakt.Visible = true;
                    throw new UserException("userex >> kontakt telefon");
                }
                if (frmRegistracija.TxtEmail.Text == "")
                {
                    frmRegistracija.LblGreskaEmail.Text = "Morate uneti email adresu";
                    frmRegistracija.LblGreskaEmail.Visible = true;
                    throw new UserException("userex >> email");
                }
                if (frmRegistracija.TxtSifra.Text == "")
                {
                    frmRegistracija.LblGreskaSifra.Text = "Morate uneti šifru";
                    frmRegistracija.LblGreskaSifra.Visible = true;
                    throw new UserException("userex >> sifra");
                }


                //validna forma
                if (!frmRegistracija.TxtEmail.Text.Contains('@') || !frmRegistracija.TxtEmail.Text.Contains('.') || !frmRegistracija.TxtEmail.Text.Any(x => char.IsLetter(x)))
                {
                    frmRegistracija.LblGreskaEmail.Text = "Email adresa nije u validnoj formi";
                    frmRegistracija.LblGreskaEmail.Visible = true;
                    throw new UserException("userex >> email forma");
                }
                if (frmRegistracija.DtpDatumRodjenja.Value.Date > DateTime.Now)
                {
                    frmRegistracija.LblGreskaDatum.Text = "Morate uneti datum u prošlosti";
                    frmRegistracija.LblGreskaDatum.Visible = true;
                    throw new UserException("userex >> datum u buducnosti");
                }
                if (!frmRegistracija.TxtKontakt.Text.All(x => char.IsDigit(x)))
                {
                    frmRegistracija.LblGreskaKontakt.Text = "Kontakt može da sadrži samo brojeve";
                    frmRegistracija.LblGreskaKontakt.Visible = true;
                    throw new UserException("userex >> kontakt telefon forma");
                }

                //broj karaktera
                if (frmRegistracija.TxtIme.Text.Length > 50)
                {
                    frmRegistracija.LblGreskaIme.Text = "Ime ne sme da ima više od 50 karaktera";
                    frmRegistracija.LblGreskaIme.Visible = true;
                    throw new UserException("userex >> ime karakteri");
                }
                if (frmRegistracija.TxtPrezime.Text.Length > 50)
                {
                    frmRegistracija.LblGreskaPrezime.Text = "Prezime ne sme da ima više od 50 karaktera";
                    frmRegistracija.LblGreskaPrezime.Visible = true;
                    throw new UserException("userex >> prezime karakteri");
                }
                if (frmRegistracija.TxtEmail.Text.Length > 50)
                {
                    frmRegistracija.LblGreskaEmail.Text = "Email ne sme da ima više od 50 karaktera";
                    frmRegistracija.LblGreskaEmail.Visible = true;
                    throw new UserException("userex >> email karakteri");
                }
                if (frmRegistracija.TxtKontakt.Text.Length > 50)
                {
                    frmRegistracija.LblGreskaKontakt.Text = "Kontakt ne sme da ima više od 50 karaktera";
                    frmRegistracija.LblGreskaKontakt.Visible = true;
                    throw new UserException("userex >> kontakt telefon karakteri");
                }
                if (frmRegistracija.TxtKontakt.Text.Length < 11)
                {
                    frmRegistracija.LblGreskaKontakt.Text = "Kontakt mora da sadrzi vise od 10 brojeva";
                    frmRegistracija.LblGreskaKontakt.Visible = true;
                    throw new UserException("userex >> kontakt telefon karakteri");
                }


                Korisnik k = PreuzmiPodatkeZaRegistraciju();
                ClientCommunication.Instance.Registracija(k);
                frmRegistracija.Close();
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

        private Korisnik PreuzmiPodatkeZaRegistraciju()
        {
            Korisnik k = new Korisnik()
            {

                Ime = frmRegistracija.TxtIme.Text,
                Prezime = frmRegistracija.TxtPrezime.Text,
                Email = frmRegistracija.TxtEmail.Text,
                DatumRodjenja = frmRegistracija.DtpDatumRodjenja.Value,
                KontaktTelefon = frmRegistracija.TxtKontakt.Text,
                Sifra = frmRegistracija.TxtSifra.Text
            };

            return k;
        }

        public void BtnPrijaviSeOnClick(object sender, EventArgs e)
        {
            try
            {
                frmPrijavljivanje.LblGreskaEmail.Visible = false;
                frmPrijavljivanje.LblGreskaSifra.Visible = false;

                //prazna polja
                if (frmPrijavljivanje.TxtKorisnickoIme.Text == "" && frmPrijavljivanje.TxtSifra.Text == "")
                {
                    frmPrijavljivanje.LblGreskaEmail.Text = "Morate uneti email adresu";
                    frmPrijavljivanje.LblGreskaEmail.Visible = true;
                    frmPrijavljivanje.LblGreskaSifra.Text = "Morate uneti šifru";
                    frmPrijavljivanje.LblGreskaSifra.Visible = true;
                    throw new UserException("userexc >> email i sifra");
                }
                if (frmPrijavljivanje.TxtKorisnickoIme.Text == "")
                {
                    frmPrijavljivanje.LblGreskaEmail.Text = "Morate uneti email adresu";
                    frmPrijavljivanje.LblGreskaEmail.Visible = true;
                    throw new UserException("userexc >> email");
                }
                if (frmPrijavljivanje.TxtSifra.Text == "")
                {
                    frmPrijavljivanje.LblGreskaSifra.Text = "Morate uneti šifru";
                    frmPrijavljivanje.LblGreskaSifra.Visible = true;
                    throw new UserException("userexc >> sifra");
                }




                //prijava korisnik
                if (!frmPrijavljivanje.CkbAdmin.Checked)
                {
                    Korisnik k = PreuzmiKorisnikPodatkeSaForme();
                    k = ClientCommunication.Instance.PrijavljivanjeKorisnik(k);
                    MainCoordinator.Instance.ulogovaniKorisnik = k;
                    MainCoordinator.Instance.PrikaziFrmKorisnik();
                }
                //prijava admin
                else
                {
                    Administrator admin = PreuzmiAdministratorPodatkeSaForme();
                    admin = ClientCommunication.Instance.PrijavljivanjeAdministrator(admin);
                    MainCoordinator.Instance.ulogovaniAdministrator = admin;
                    MainCoordinator.Instance.PrikaziFrmAdministrator();
                }

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

        private Administrator PreuzmiAdministratorPodatkeSaForme()
        {
            Administrator admin = new Administrator()
            {
                KorisnickoIme = frmPrijavljivanje.TxtKorisnickoIme.Text,
                Sifra = frmPrijavljivanje.TxtSifra.Text
            };
            return admin;
        }

        private Korisnik PreuzmiKorisnikPodatkeSaForme()
        {
            Korisnik k = new Korisnik()
            {
                Email = frmPrijavljivanje.TxtKorisnickoIme.Text,
                Sifra = frmPrijavljivanje.TxtSifra.Text
            };
            return k;
        }
    }
}
