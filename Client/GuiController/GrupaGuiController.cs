using Client.Communication;
using Client.UserControls;
using Common;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class GrupaGuiController
    {
        private UcPretragaGrupa ucPretragaGrupa;
        #region Vise Grupa
        internal Control KreirajUcPrikazGrupaAdministrator()
        {
            ucPretragaGrupa = new UcPretragaGrupa();

            ucPretragaGrupa.DgvListaGrupa.DataSource = new BindingList<Grupa>(ClientCommunication.Instance.VratiSveGrupe());
            ucPretragaGrupa.TxtPretraga.TextChanged += TxtFilterPretrazi;
            ucPretragaGrupa.BtnIzaberi.Click += IzaberiProgramTreningaZaIzmenu;
            return ucPretragaGrupa;
        }
        private void IzaberiProgramTreningaZaIzmenu(object sender, EventArgs e)
        {
            try
            {
                ucPretragaGrupa.LblGreska.Visible = false;

                if (ucPretragaGrupa.DgvListaGrupa.SelectedRows.Count != 1)
                {
                    ucPretragaGrupa.LblGreska.Text = "Morate da odaberete jedan program treninga";
                    ucPretragaGrupa.LblGreska.Visible = true;
                    throw new UserException("userex >> selektovan program treninga");
                }
                Grupa grupa = (Grupa)ucPretragaGrupa.DgvListaGrupa.SelectedRows[0].DataBoundItem;
                Grupa g = ClientCommunication.Instance.VratiGrupu(grupa);
                MainCoordinator.Instance.PrikaziPodatkeOgrupi(g);
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

        private void TxtFilterPretrazi(object sender, EventArgs e)
        {
            try
            {
                string filter = ucPretragaGrupa.TxtPretraga.Text;
                if (filter.Length > 0)
                {

                    Grupa g = new Grupa()
                    {
                        SearchQuery = $" lower(Grupa.NazivGrupe) like '%{filter}%'"
                    };
                    List<Grupa> filtriraneGrupe = ClientCommunication.Instance.PretraziGrupe(g);
                    ucPretragaGrupa.DgvListaGrupa.DataSource = filtriraneGrupe;
                }
                else
                {
                    List<Grupa> grupe = ClientCommunication.Instance.VratiSveGrupe();
                    ucPretragaGrupa.DgvListaGrupa.DataSource = grupe;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region singleGrupa
        private UcKreirajGrupu ucKreirajGrupu;
        private FormMode formMode;
        private BindingList<Prijava> prijaveUGrupi = new BindingList<Prijava>();
        private BindingList<Prijava> prijaveVanGrupe = new BindingList<Prijava>();
        private List<Prijava> zaDodavanjeUGrupu = new List<Prijava>();
        private List<Prijava> zaIzbacivanjeIzGrupe = new List<Prijava>();
        private Grupa grupa;
        internal Control KreirajUcPrikazGrupe(FormMode mode, Grupa g)
        {
            ucKreirajGrupu = new UcKreirajGrupu();
            grupa = g;

            ucKreirajGrupu.CbProgramTreninga.DataSource = new BindingList<ProgramTreninga>(ClientCommunication.Instance.VratiSveProgrameTreninga());
            if (g != null)
            {
                ucKreirajGrupu.TxtNazivGrupe.Text = g.NazivGrupe;
                ucKreirajGrupu.CbProgramTreninga.SelectedItem = g.ProgramTreninga;
                ucKreirajGrupu.DtpPocetak.Value = g.DatumPocetka;
                ucKreirajGrupu.DtpKraj.Value = g.DatumKraja;
                prijaveUGrupi = new BindingList<Prijava>(ClientCommunication.Instance.VratiPrijaveZaGrupu(g));
                ucKreirajGrupu.DgvPrijaveUGrupi.DataSource = prijaveUGrupi;
                prijaveVanGrupe = new BindingList<Prijava>(ClientCommunication.Instance.VratiPrijaveVanGrupe(g));
                ucKreirajGrupu.DgvPrijaveVanGrupe.DataSource = prijaveVanGrupe;
            }
            if (g == null)
            {
                ucKreirajGrupu.CbProgramTreninga.SelectedIndex = -1;
                ucKreirajGrupu.CbProgramTreninga.SelectedIndexChanged += (s, e) => VratiPrijave();
            }
            ucKreirajGrupu.BtnUbaci.Click += (s, e) => DodajPrijavuUGrupu();
            ucKreirajGrupu.BtnIzbaci.Click += (s, e) => IzbaciPrijavuIzGrupe();
            ucKreirajGrupu.BtnObrisi.Click += (s, e) => ObrisiGrupu();
            ucKreirajGrupu.BtnSacuvaj.Click += (s, e) => SacuvajGrupu(mode);

            return ucKreirajGrupu;
        }

        private void VratiPrijave()
        {
            try
            {
                ProgramTreninga pt = (ProgramTreninga)ucKreirajGrupu.CbProgramTreninga.SelectedItem;
                prijaveVanGrupe = new BindingList<Prijava>(ClientCommunication.Instance.VratiPrijaveZaProgramTreninga(pt));
                ucKreirajGrupu.DgvPrijaveVanGrupe.DataSource = prijaveVanGrupe;
                prijaveUGrupi.Clear();
                ucKreirajGrupu.DgvPrijaveUGrupi.DataSource = prijaveUGrupi;
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

        private void SacuvajGrupu(FormMode mode)
        {
            try
            {
                ucKreirajGrupu.LblGreskaDatumKraja.Visible = false;
                ucKreirajGrupu.LblGreskaNazivGrupe.Visible = false;
                ucKreirajGrupu.LblGreskaDatumPocetka.Visible = false;
                ucKreirajGrupu.LblGreskaProgramTreninga.Visible = false;

                //prazna polja
                if (ucKreirajGrupu.TxtNazivGrupe.Text == "")
                {
                    ucKreirajGrupu.LblGreskaNazivGrupe.Text = "Morate uneti naziv treninga";
                    ucKreirajGrupu.LblGreskaNazivGrupe.Visible = true;
                    throw new UserException("userexc >> naziv treninga");
                }

                if (ucKreirajGrupu.CbProgramTreninga.SelectedIndex == -1)
                {
                    ucKreirajGrupu.LblGreskaProgramTreninga.Text = "Morate uneti dan u nedelji";
                    ucKreirajGrupu.LblGreskaProgramTreninga.Visible = true;
                    throw new UserException("userexc >> dan u nedelji");
                }

                //broj karaktera
                if (ucKreirajGrupu.TxtNazivGrupe.Text.Length > 50)
                {
                    ucKreirajGrupu.LblGreskaNazivGrupe.Text = "Naziv ne sme da ima više od 50 karaktera";
                    ucKreirajGrupu.LblGreskaNazivGrupe.Visible = true;
                    throw new UserException("userex >> naziv karakteri");
                }

                Grupa g = new Grupa()
                {
                    NazivGrupe = ucKreirajGrupu.TxtNazivGrupe.Text,
                    ProgramTreninga = (ProgramTreninga)ucKreirajGrupu.CbProgramTreninga.SelectedItem,
                    DatumPocetka = ucKreirajGrupu.DtpPocetak.Value,
                    DatumKraja = ucKreirajGrupu.DtpKraj.Value,
                    zaDodavanje = zaDodavanjeUGrupu,
                    zaBrisanje = zaIzbacivanjeIzGrupe
                };
                if (mode == FormMode.Edit)
                {
                    g.GrupaId = grupa.GrupaId;
                    ClientCommunication.Instance.IzmeniGrupu(g);
                }
                else if (mode == FormMode.Add)
                {
                    ClientCommunication.Instance.KreirajGrupu(g);
                    ucKreirajGrupu.Dispose();
                }
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

        private void ObrisiGrupu()
        {
            ClientCommunication.Instance.ObrisiGrupu(grupa);
            MainCoordinator.Instance.PrikaziSveGrupeAdministrator();
        }

        private void IzbaciPrijavuIzGrupe()
        {
            try
            {
                ucKreirajGrupu.LblGreskaPrijaveUGrupi.Visible = false;
                if (ucKreirajGrupu.DgvPrijaveUGrupi.SelectedRows.Count != 1)
                {
                    ucKreirajGrupu.LblGreskaVanGrupe.Text = "Morate da odaberete jednu prijavu";
                    ucKreirajGrupu.LblGreskaVanGrupe.Visible = true;
                    throw new UserException("userex >> selektovana prijava");
                }
                Prijava prijava = (Prijava)ucKreirajGrupu.DgvPrijaveUGrupi.SelectedRows[0].DataBoundItem;
                if (zaDodavanjeUGrupu.Contains(prijava))
                {
                    zaDodavanjeUGrupu.Remove(prijava);
                }
                else
                {
                    zaIzbacivanjeIzGrupe.Add(prijava);
                }
                prijaveVanGrupe.Add(prijava);
                prijaveUGrupi.Remove(prijava);
                ucKreirajGrupu.DgvPrijaveUGrupi.DataSource = prijaveUGrupi;
                ucKreirajGrupu.DgvPrijaveVanGrupe.DataSource = prijaveVanGrupe;
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

        private void DodajPrijavuUGrupu()
        {
            try
            {
                ucKreirajGrupu.LblGreskaVanGrupe.Visible = false;

                if (ucKreirajGrupu.DgvPrijaveVanGrupe.SelectedRows.Count != 1)
                {
                    ucKreirajGrupu.LblGreskaVanGrupe.Text = "Morate da odaberete jednu prijavu";
                    ucKreirajGrupu.LblGreskaVanGrupe.Visible = true;
                    throw new UserException("userex >> selektovana prijava");
                }
                Prijava prijava = (Prijava)ucKreirajGrupu.DgvPrijaveVanGrupe.SelectedRows[0].DataBoundItem;

                if (zaIzbacivanjeIzGrupe.Contains(prijava))
                {
                    zaIzbacivanjeIzGrupe.Remove(prijava);
                }
                else
                {
                    zaDodavanjeUGrupu.Add(prijava);
                }
                prijaveUGrupi.Add(prijava);
                prijaveVanGrupe.Remove(prijava);
                ucKreirajGrupu.DgvPrijaveUGrupi.DataSource = prijaveUGrupi;
                ucKreirajGrupu.DgvPrijaveVanGrupe.DataSource = prijaveVanGrupe;
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
        #endregion
    }
}
