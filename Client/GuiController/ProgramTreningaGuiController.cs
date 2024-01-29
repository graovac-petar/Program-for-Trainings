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
        internal Control KreirajUcIzmenaProgramTreninga(FormMode edit, ProgramTreninga pt)
        {
            ucKreirajProgramTreninga = new UcKreirajProgramTreninga();
            ucKreirajProgramTreninga.TxtNazivProgramaTreninga.Text = pt.NazivProgramaTreninga;
            ucKreirajProgramTreninga.TxtBrojTreningaNedeljno.Text = pt.BrojTreningaNedeljno.ToString();
            ucKreirajProgramTreninga.TxtOpis.Text = pt.Opis;
            ucKreirajProgramTreninga.TxtCena.Text = pt.Cena.ToString();
            ucKreirajProgramTreninga.DgvTreninzi.DataSource = new BindingList<Trening>(ClientCommunication.Instance.VratiSveTreningeZaProgramTreninga(pt));
            return ucKreirajProgramTreninga;
        }

        internal Control KreirajUcIzmenaProgramTreninga(FormMode add)
        {
            ucKreirajProgramTreninga = new UcKreirajProgramTreninga();

            return ucKreirajProgramTreninga;
        }
        #endregion
    }
}
