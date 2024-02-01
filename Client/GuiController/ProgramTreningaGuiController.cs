using Client.Communication;
using Client.UserControls;
using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class ProgramTreningaGuiController
    {
        private FormMode formMode;
        private ProgramTreninga programTreninga;
        private Trening Trening;
        private UcPretragaProgramaTreninga ucPretragaProgramaTreninga;
        internal Control KreirajUcPrikazProgramaTreninga(FormMode formmode)
        {
            ucPretragaProgramaTreninga = new UcPretragaProgramaTreninga();
            ucPretragaProgramaTreninga.DgvListaProgramaTreninga.DataSource = new BindingList<ProgramTreninga>(ClientCommunication.Instance.VratiSveProgrameTreninga());

            ucPretragaProgramaTreninga.DgvListaProgramaTreninga.Columns["ProgramTreningaId"].Visible = false;
            ucPretragaProgramaTreninga.DgvListaProgramaTreninga.Columns["NazivProgramaTreninga"].HeaderText = "Naziv Programa Treninga";
            ucPretragaProgramaTreninga.DgvListaProgramaTreninga.Columns["BrojTreningaNedeljno"].HeaderText = "Broj Treninga Nedeljno";

            ucPretragaProgramaTreninga.TxtPretraga.TextChanged += TxtFilterPretrazi;
            if (formmode == FormMode.ChooseAdmin)
            {
                ucPretragaProgramaTreninga.BtnIzaberi.Click += IzaberiProgramTreningaZaIzmenu;
            }
            if (formmode == FormMode.ChooseKorisnik)
            {
                ucPretragaProgramaTreninga.BtnIzaberi.Click += IzaberiProgramTreningaZaprikaz;
            }
            return ucPretragaProgramaTreninga;
        }

        private void IzaberiProgramTreningaZaIzmenu(object sender, EventArgs e)
        {
            try
            {
                ucPretragaProgramaTreninga.LblGreska.Visible = false;

                if (ucPretragaProgramaTreninga.DgvListaProgramaTreninga.SelectedRows.Count != 1)
                {
                    ucPretragaProgramaTreninga.LblGreska.Text = "Morate da odaberete jedan program treninga";
                    ucPretragaProgramaTreninga.LblGreska.Visible = true;
                    throw new UserException("userex >> selektovan program treninga");
                }
                ProgramTreninga programTreninga = (ProgramTreninga)ucPretragaProgramaTreninga.DgvListaProgramaTreninga.SelectedRows[0].DataBoundItem;
                ProgramTreninga pt = ClientCommunication.Instance.VratiProgramTreninga(programTreninga);
                MainCoordinator.Instance.PrikaziPodatkeOProgramuTreningaAdministrator(pt);
            }
            catch (UserException ex)
            {

                Console.WriteLine();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void IzaberiProgramTreningaZaprikaz(object sender, EventArgs e)
        {
            try
            {
                ucPretragaProgramaTreninga.LblGreska.Visible = false;

                if (ucPretragaProgramaTreninga.DgvListaProgramaTreninga.SelectedRows.Count != 1)
                {
                    ucPretragaProgramaTreninga.LblGreska.Text = "Morate da odaberete jedan program treninga";
                    ucPretragaProgramaTreninga.LblGreska.Visible = true;
                    throw new UserException("userex >> selektovan program treninga");
                }

                ProgramTreninga programTreninga = (ProgramTreninga)ucPretragaProgramaTreninga.DgvListaProgramaTreninga.SelectedRows[0].DataBoundItem;
                ProgramTreninga pt = ClientCommunication.Instance.VratiProgramTreninga(programTreninga);
                MainCoordinator.Instance.PrikaziPodatkeOProgramuTreningaKorisnik(pt);
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

        private void TxtFilterPretrazi(object sender, EventArgs e)
        {
            try
            {
                string filter = ucPretragaProgramaTreninga.TxtPretraga.Text;
                if (filter.Length > 0)
                {

                    ProgramTreninga pt = new ProgramTreninga()
                    {
                        SearchQuery = $" lower(ProgramTreninga.NazivProgramaTreninga) like '%{filter}%'"
                    };
                    List<ProgramTreninga> filtriraniprogramiTreninga = ClientCommunication.Instance.PretraziProgrameTreninga(pt);
                    ucPretragaProgramaTreninga.DgvListaProgramaTreninga.DataSource = filtriraniprogramiTreninga;
                }
                else
                {
                    List<ProgramTreninga> programiTreinga = ClientCommunication.Instance.VratiSveProgrameTreninga();
                    ucPretragaProgramaTreninga.DgvListaProgramaTreninga.DataSource = programiTreinga;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #region Single Program Treninga

        private UcSingleProgramTreninga ucSingleProgramTreningaView;
        public ProgramTreninga programTreningaView;
        internal Control KreirajUcPrikaziProgramTreninga(FormMode mode, ProgramTreninga pt)
        {
            ucSingleProgramTreningaView = new UcSingleProgramTreninga();
            ucSingleProgramTreningaView.TxtNaziv.Text = pt.NazivProgramaTreninga;
            ucSingleProgramTreningaView.TxtBrojTreninga.Text = pt.BrojTreningaNedeljno.ToString();
            ucSingleProgramTreningaView.TxtOpisProgramaTreninga.Text = pt.Opis;
            ucSingleProgramTreningaView.TxtCena.Text = pt.Cena.ToString();
            ucSingleProgramTreningaView.DgvTreninzi.DataSource = new BindingList<Trening>(ClientCommunication.Instance.VratiSveTreningeZaProgramTreninga(pt));
            ucSingleProgramTreningaView.BtnPrijaviSe.Click += (s, e) => MainCoordinator.Instance.PrikaziKreirajPrijavuNaProgramTreninga(pt);
            if (mode == FormMode.ChooseKorisnik)
            {
                ucSingleProgramTreningaView.TxtBrojTreninga.Enabled = false;
                ucSingleProgramTreningaView.TxtNaziv.Enabled = false;
                ucSingleProgramTreningaView.TxtOpisProgramaTreninga.Enabled = false;
                ucSingleProgramTreningaView.TxtCena.Enabled = false;
            }
            if (mode == FormMode.ChooseAdmin)
            {
                ucSingleProgramTreningaView.BtnPrijaviSe.Visible = false;
            }

            return ucSingleProgramTreningaView;
        }
        #endregion
        private UcKreirajProgramTreninga ucKreirajProgramTreninga;
        #region CRUD ADMIN PROGRAM TRENINGA
        BindingList<Trening> treninzi = new BindingList<Trening>();
        List<Trening> treninziZaBrisanje = new List<Trening>();
        List<Trening> treninziZaDodavanje = new List<Trening>();
        internal Control KreirajUcIzmenaProgramTreninga(FormMode edit, ProgramTreninga pt)
        {
            ucKreirajProgramTreninga = new UcKreirajProgramTreninga();
            programTreninga = pt;

            ucKreirajProgramTreninga.LblGreskaDanUNedelji.Visible = false;
            ucKreirajProgramTreninga.LblGreskaNazivTreninga.Visible = false;
            ucKreirajProgramTreninga.LblGreskaOpisTreninga.Visible = false;
            ucKreirajProgramTreninga.LblGreskaTrajanje.Visible = false;
            ucKreirajProgramTreninga.LblGreskaBrisanje.Visible = false;
            ucKreirajProgramTreninga.CbDanUNedelji.DataSource = Enum.GetValues(typeof(DanUNedelji));
            if (pt == null)
            {
                ucKreirajProgramTreninga.BtnObrisi.Visible = false;
            }

            if (pt != null)
            {
                ucKreirajProgramTreninga.CbDanUNedelji.SelectedIndex = -1;
                ucKreirajProgramTreninga.TxtNazivProgramaTreninga.Text = pt.NazivProgramaTreninga;
                ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text = pt.BrojTreningaNedeljno.ToString();
                ucKreirajProgramTreninga.TxtOpis.Text = pt.Opis;
                ucKreirajProgramTreninga.TxtCena.Text = pt.Cena.ToString();
            }
            treninzi = new BindingList<Trening>(ClientCommunication.Instance.VratiSveTreningeZaProgramTreninga(pt));
            ucKreirajProgramTreninga.DgvTreninzi.DataSource = treninzi;

            ucKreirajProgramTreninga.BtnDodajTrening.Click += (s, e) => DodajTrening();
            ucKreirajProgramTreninga.BtnObrisiTrening.Click += (s, e) => ObrisiTrening();
            ucKreirajProgramTreninga.BtnSacuvaj.Click += (s, e) => SacuvajProgramTreninga(edit);
            ucKreirajProgramTreninga.BtnObrisi.Click += (s, e) => ObrisiProgramTreninga();
            return ucKreirajProgramTreninga;
        }

        private void ObrisiProgramTreninga()
        {
            ClientCommunication.Instance.ObrisiProgramTreninga(programTreninga);
            MainCoordinator.Instance.PrikaziSveProgramTreningaAdministrator();
        }

        private void SacuvajProgramTreninga(FormMode mode)
        {
            try
            {
                ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Visible = false;
                ucKreirajProgramTreninga.LblGreskaCena.Visible = false;
                ucKreirajProgramTreninga.LblGreskaOpisProgramaTreninga.Visible = false;
                ucKreirajProgramTreninga.LblGreskaNazivProgramaTreninga.Visible = false;

                //prazna polja
                if (ucKreirajProgramTreninga.TxtNazivProgramaTreninga.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaNazivProgramaTreninga.Text = "Morate uneti naziv programa treninga";
                    ucKreirajProgramTreninga.LblGreskaNazivProgramaTreninga.Visible = true;
                    throw new UserException("userexc >> naziv programa treninga");
                }
                if (ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Text = "Morate uneti broj treninga nedeljno";
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Visible = true;
                    throw new UserException("userexc >> broj treninga nedeljno");
                }
                if (ucKreirajProgramTreninga.TxtOpis.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaOpisProgramaTreninga.Text = "Morate uneti opis";
                    ucKreirajProgramTreninga.LblGreskaOpisProgramaTreninga.Visible = true;
                    throw new UserException("userexc >> opis");
                }
                if (ucKreirajProgramTreninga.TxtCena.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaCena.Text = "Morate uneti cenu";
                    ucKreirajProgramTreninga.LblGreskaCena.Visible = true;
                    throw new UserException("userexc >> cena");
                }

                //broj karaktera
                if (ucKreirajProgramTreninga.TxtNazivProgramaTreninga.Text.Length > 50)
                {
                    ucKreirajProgramTreninga.LblGreskaNazivProgramaTreninga.Text = "Naziv ne sme da ima više od 50 karaktera";
                    ucKreirajProgramTreninga.LblGreskaNazivProgramaTreninga.Visible = true;
                    throw new UserException("userex >> naziv karakteri");
                }
                if (!ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text.All(x => char.IsDigit(x)))
                {
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Text = "Broj treninga nedeljno može da sadrži samo brojeve";
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Visible = true;
                    throw new UserException("userex >> broj treninga nedeljno broj");
                }
                if (ucKreirajProgramTreninga.TxtOpis.Text.Length > 500)
                {
                    ucKreirajProgramTreninga.LblGreskaOpisProgramaTreninga.Text = "Opis ne sme da ima više od 500 karaktera";
                    ucKreirajProgramTreninga.LblGreskaOpisProgramaTreninga.Visible = true;
                    throw new UserException("userex >> opis karakteri");
                }
                if (!ucKreirajProgramTreninga.TxtCena.Text.All((x => char.IsDigit(x) || x == ',')))
                {
                    ucKreirajProgramTreninga.LblGreskaCena.Text = "Cena može da sadrži samo brojeve";
                    ucKreirajProgramTreninga.LblGreskaCena.Visible = true;
                    throw new UserException("userex >> cena broj");
                }
                if ((ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text.Count(x => x == ',') > 1) || ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text.StartsWith(",") || ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text.EndsWith(","))
                {
                    ucKreirajProgramTreninga.LblGreskaCena.Text = "Nepravilan unos";
                    ucKreirajProgramTreninga.LblGreskaCena.Visible = true;
                    throw new UserException("userex >> cena broj");
                }
                if (int.Parse(ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text) < 1 || int.Parse(ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text) > 7)
                {
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Text = "Broj treninga mora biti od 1 do 7";
                    ucKreirajProgramTreninga.LblGreskaBrojTreningaNedeljno.Visible = true;
                    throw new UserException("userex >> cena broj");
                }
                if (treninzi.Count != int.Parse(ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text))
                {
                    ucKreirajProgramTreninga.LblGreskaBrisanje.Text = "Broj treninga nedeljno mora biti jednak broju napravljenih treninga";
                    ucKreirajProgramTreninga.LblGreskaBrisanje.Visible = true;
                    throw new UserException("userex >> trening");
                }
                ProgramTreninga pt = new ProgramTreninga()
                {
                    NazivProgramaTreninga = ucKreirajProgramTreninga.TxtNazivProgramaTreninga.Text,
                    BrojTreningaNedeljno = int.Parse(ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text),
                    Opis = ucKreirajProgramTreninga.TxtOpis.Text,
                    Cena = double.Parse(ucKreirajProgramTreninga.TxtCena.Text),
                    TreninziZaDodavanje = treninziZaDodavanje.ToList<Trening>(),
                    TreninziZaBrisanje = treninziZaBrisanje.ToList<Trening>()
                };
                if (mode == FormMode.Edit)
                {
                    pt.ProgramTreningaId = programTreninga.ProgramTreningaId;
                    ClientCommunication.Instance.IzmeniProgramTreninga(pt);
                }
                else if (mode == FormMode.Add)
                {
                    ClientCommunication.Instance.KreirajProgramTreninga(pt);
                    ucKreirajProgramTreninga.Dispose();
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

        private void ObrisiTrening()
        {
            try
            {
                if (ucKreirajProgramTreninga.DgvTreninzi.SelectedRows.Count != 1)
                {
                    ucKreirajProgramTreninga.LblGreskaBrisanje.Text = "Morate da odaberete jedan trening";
                    ucKreirajProgramTreninga.LblGreskaBrisanje.Visible = true;
                    throw new UserException("userex >> selektovan trening");
                }
                Trening tk = (Trening)ucKreirajProgramTreninga.DgvTreninzi.SelectedRows[0].DataBoundItem;

                treninzi.Remove(tk);
                if (treninziZaDodavanje.Contains(tk))
                    treninziZaDodavanje.Remove(tk);
                else
                    treninziZaBrisanje.Add(tk);
                ucKreirajProgramTreninga.DgvTreninzi.DataSource = treninzi;
            }
            catch (UserException ex)
            {

                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajTrening()
        {
            try
            {
                ucKreirajProgramTreninga.LblGreskaDanUNedelji.Visible = false;
                ucKreirajProgramTreninga.LblGreskaNazivTreninga.Visible = false;
                ucKreirajProgramTreninga.LblGreskaOpisTreninga.Visible = false;
                ucKreirajProgramTreninga.LblGreskaTrajanje.Visible = false;

                //prazna polja
                if (ucKreirajProgramTreninga.TxtNazivTreninga.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaNazivTreninga.Text = "Morate uneti naziv treninga";
                    ucKreirajProgramTreninga.LblGreskaNazivTreninga.Visible = true;
                    throw new UserException("userexc >> naziv treninga");
                }
                if (ucKreirajProgramTreninga.TxtOpisTreninga.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaOpisTreninga.Text = "Morate uneti opis treninga";
                    ucKreirajProgramTreninga.LblGreskaOpisTreninga.Visible = true;
                    throw new UserException("userexc >> opis treninga");
                }
                if (ucKreirajProgramTreninga.TxtTrajanjeUMinutima.Text == "")
                {
                    ucKreirajProgramTreninga.LblGreskaTrajanje.Text = "Morate uneti trajanje";
                    ucKreirajProgramTreninga.LblGreskaTrajanje.Visible = true;
                    throw new UserException("userexc >> trajanje");
                }
                if (ucKreirajProgramTreninga.CbDanUNedelji.SelectedIndex == -1)
                {
                    ucKreirajProgramTreninga.LblGreskaDanUNedelji.Text = "Morate uneti dan u nedelji";
                    ucKreirajProgramTreninga.LblGreskaDanUNedelji.Visible = true;
                    throw new UserException("userexc >> dan u nedelji");
                }

                //broj karaktera
                if (ucKreirajProgramTreninga.TxtNazivTreninga.Text.Length > 50)
                {
                    ucKreirajProgramTreninga.LblGreskaNazivTreninga.Text = "Naziv ne sme da ima više od 50 karaktera";
                    ucKreirajProgramTreninga.LblGreskaNazivTreninga.Visible = true;
                    throw new UserException("userex >> naziv karakteri");
                }
                if (ucKreirajProgramTreninga.TxtOpisTreninga.Text.Length > 500)
                {
                    ucKreirajProgramTreninga.LblGreskaOpisTreninga.Text = "Prezime ne sme da ima više od 500 karaktera";
                    ucKreirajProgramTreninga.LblGreskaOpisTreninga.Visible = true;
                    throw new UserException("userex >> opis karakteri");
                }
                if (!ucKreirajProgramTreninga.TxtTrajanjeUMinutima.Text.All(x => char.IsDigit(x)))
                {
                    ucKreirajProgramTreninga.LblGreskaTrajanje.Text = "trajanje može da sadrži samo brojeve";
                    ucKreirajProgramTreninga.LblGreskaTrajanje.Visible = true;
                    throw new UserException("userex >> trajanje broj");
                }
                Trening trening = new Trening()
                {
                    NaziTreninga = ucKreirajProgramTreninga.TxtNazivTreninga.Text,
                    OpisTreninga = ucKreirajProgramTreninga.TxtOpisTreninga.Text,
                    TrajanjeUMinutima = int.Parse(ucKreirajProgramTreninga.TxtTrajanjeUMinutima.Text),
                    DanUNedelji = (DanUNedelji)ucKreirajProgramTreninga.CbDanUNedelji.SelectedItem
                };
                treninzi.Add(trening);
                treninziZaDodavanje.Add(trening);
                ucKreirajProgramTreninga.DgvTreninzi.DataSource = treninzi;
                ObrisiPodatkeZaTrening();
            }
            catch (UserException)
            {
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObrisiPodatkeZaTrening()
        {
            ucKreirajProgramTreninga.TxtNazivTreninga.Text = "";
            ucKreirajProgramTreninga.TxtOpisTreninga.Text = "";
            ucKreirajProgramTreninga.TxtTrajanjeUMinutima.Text = "";
            ucKreirajProgramTreninga.CbDanUNedelji.SelectedIndex = -1;
        }

        #endregion
    }
}
