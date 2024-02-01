using Common;
using Common.Model;
using Repository.Implementation;
using Repository.Interfaces;
using System.Collections.Generic;
using SystemOperation;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();

                }
                return instance;
            }
        }
        IRepository<Korisnik> korisnikRepository;
        IRepository<IEntity> genericRepository;

        private Controller()
        {
            genericRepository = new GenericDbRepository();
        }

        #region Korisnik
        public Korisnik KorisnikPrijavljivanje(Korisnik k)
        {
            PrijaviSeKorisnikSystemOperation prijaviSeKorisnikSystemOperation = new PrijaviSeKorisnikSystemOperation();
            prijaviSeKorisnikSystemOperation.Korisnik = k;
            prijaviSeKorisnikSystemOperation.Execute();

            return prijaviSeKorisnikSystemOperation.Korisnik;
        }

        public Korisnik KorisnikRegistracija(Korisnik k)
        {
            RegistrujSeSystemOperation registrujSeSystemOperation = new RegistrujSeSystemOperation();
            registrujSeSystemOperation.RegistrujKorisnika(k);
            registrujSeSystemOperation.Execute();

            return registrujSeSystemOperation.Korisnik;
        }
        #endregion

        #region Administrator
        internal Administrator AdministratorPrijavljivanje(Administrator a)
        {
            PrijaviSeAdministratorSystemOperation prijaviSeAdministratorSystemOperation = new PrijaviSeAdministratorSystemOperation();
            prijaviSeAdministratorSystemOperation.Administrator = a;
            prijaviSeAdministratorSystemOperation.Execute();

            return prijaviSeAdministratorSystemOperation.Administrator;
        }
        #endregion

        #region ProgramTreninga
        internal List<ProgramTreninga> VratiSveProgrameTreninga()
        {
            VratiSveProgrameTreningaSystemOperation vratiSveProgrameTreningaSystemOperation = new VratiSveProgrameTreningaSystemOperation();
            vratiSveProgrameTreningaSystemOperation.Execute();
            return vratiSveProgrameTreningaSystemOperation.programiTreninga;
        }

        internal List<ProgramTreninga> PretraziProgramTreninga(ProgramTreninga body)
        {
            PretraziProgrameTreningaSystemOperation pretraziProgramTreningaSystemOperation = new PretraziProgrameTreningaSystemOperation();
            pretraziProgramTreningaSystemOperation.programTreninga = body;
            pretraziProgramTreningaSystemOperation.Execute();

            return pretraziProgramTreningaSystemOperation.listaprogramaTreninga;
        }

        internal ProgramTreninga VratiProgramTreninga(ProgramTreninga body)
        {
            VratiProgramTreningaSystemOperation vratiProgramTreningaSystemOperation = new VratiProgramTreningaSystemOperation();
            vratiProgramTreningaSystemOperation.programTreninga = body;
            vratiProgramTreningaSystemOperation.Execute();

            return vratiProgramTreningaSystemOperation.programTreninga;
        }
        internal void KreirajProgramTreninga(ProgramTreninga body)
        {
            KreirajProgramTreningaSystemOperation kreirajProgramTreningaSystemOperation = new KreirajProgramTreningaSystemOperation();
            kreirajProgramTreningaSystemOperation.programTreninga = body;
            kreirajProgramTreningaSystemOperation.Execute();

        }
        internal void IzmeniProgramTreninga(ProgramTreninga body)
        {
            IzmeniProgramTreningaSystemOperation izmeniProgramTreningaSystemOperation = new IzmeniProgramTreningaSystemOperation();
            izmeniProgramTreningaSystemOperation.programTreninga = body;
            izmeniProgramTreningaSystemOperation.Execute();
        }
        internal void ObrisiProgramTreninga(ProgramTreninga body)
        {
            ObrisiProgramTreningaSystemOperation obrisiProgramTreningaSystemOperation = new ObrisiProgramTreningaSystemOperation();
            obrisiProgramTreningaSystemOperation.programTreninga = body;
            obrisiProgramTreningaSystemOperation.Execute();
        }

        #endregion 

        #region Trening
        internal List<Trening> VratiTreninge(ProgramTreninga body)
        {
            VratiTreningeSystemOperation vratiTreningeSystemOperation = new VratiTreningeSystemOperation();
            vratiTreningeSystemOperation.ProgramTreninga = body;
            vratiTreningeSystemOperation.Execute();

            return vratiTreningeSystemOperation.listaTreninga;
        }
        #endregion

        #region Prijave
        internal Prijava VratiPrijavuZaProgramTreninga(Prijava body)
        {
            VratiPrijavuZaProgramTreningaSystemOperation vratiPrijavuZaProgramTreningaSystemOperation = new VratiPrijavuZaProgramTreningaSystemOperation();
            vratiPrijavuZaProgramTreningaSystemOperation.Prijava = body;
            vratiPrijavuZaProgramTreningaSystemOperation.Execute();

            return vratiPrijavuZaProgramTreningaSystemOperation.Prijava;
        }

        internal void PosaljiPrijavuZaProgramTreninga(Prijava body)
        {
            PosaljiPrijavuZaProgramTreningaSystemOperation posaljiPrijavuZaProgramTreningaSystemOperation = new PosaljiPrijavuZaProgramTreningaSystemOperation();
            posaljiPrijavuZaProgramTreningaSystemOperation.prijava = body;
            posaljiPrijavuZaProgramTreningaSystemOperation.Execute();
        }

        internal List<Prijava> VratiPrijaveZaKorisnuka(Korisnik body)
        {
            VratiSvePrijaveZaKorisnikaSystemOperation vratiSvePrijaveZaKorisnikaSystemOperation = new VratiSvePrijaveZaKorisnikaSystemOperation();
            vratiSvePrijaveZaKorisnikaSystemOperation.korisnik = body;
            vratiSvePrijaveZaKorisnikaSystemOperation.Execute();
            return vratiSvePrijaveZaKorisnikaSystemOperation.listaPrijava;

        }
        internal List<Prijava> VratiPrijavezaGrupu(Grupa body)
        {
            VratiPrijavaZaGrupuSystemOperation vratiPrijavaZaGrupuSystemOperation = new VratiPrijavaZaGrupuSystemOperation();
            vratiPrijavaZaGrupuSystemOperation.Grupa = body;
            vratiPrijavaZaGrupuSystemOperation.Execute();

            return vratiPrijavaZaGrupuSystemOperation.prijave;
        }
        internal List<Prijava> VratiPrijaveVanGrupe(Grupa body)
        {
            VratiPrijaveVanGrupeSystemOperation vratiPrijaveVanGrupeSystemOperation = new VratiPrijaveVanGrupeSystemOperation();
            vratiPrijaveVanGrupeSystemOperation.Grupa = body;
            vratiPrijaveVanGrupeSystemOperation.Execute();

            return vratiPrijaveVanGrupeSystemOperation.prijave;
        }
        #endregion

        #region Grupa
        internal List<Grupa> VratiSveGrupe()
        {
            VratiSveGrupeSystemOperation vratiSveGrupeSystemOperation = new VratiSveGrupeSystemOperation();
            vratiSveGrupeSystemOperation.Execute();
            return vratiSveGrupeSystemOperation.grupe;
        }

        internal List<Grupa> PretraziGrupe(Grupa body)
        {
            PretraziGrupeSystemOperation pretraziGrupeSystemOperation = new PretraziGrupeSystemOperation();
            pretraziGrupeSystemOperation.grupa = body;
            pretraziGrupeSystemOperation.Execute();

            return pretraziGrupeSystemOperation.grupe;
        }

        internal Grupa VratiGrupu(Grupa body)
        {
            VratiGrupuSystemOperation vratiGrupuSystemOperation = new VratiGrupuSystemOperation();
            vratiGrupuSystemOperation.Grupa = body;
            vratiGrupuSystemOperation.Execute();

            return vratiGrupuSystemOperation.Grupa;
        }

        internal void ObrisiGrupu(Grupa body)
        {
            ObrisiGrupuSystemOperation obrisiGrupuSystemOperation = new ObrisiGrupuSystemOperation();
            obrisiGrupuSystemOperation.grupa = body;
            obrisiGrupuSystemOperation.Execute();
        }

        internal List<Prijava> VratiPrijaveZaProgramTreninga(ProgramTreninga body)
        {
            VratiPrijaveZaProgramTreningaSystemOperation vratiPrijaveZaProgramTreningaSystemOperation = new VratiPrijaveZaProgramTreningaSystemOperation();
            vratiPrijaveZaProgramTreningaSystemOperation.ProgramTreninga = body;
            vratiPrijaveZaProgramTreningaSystemOperation.Execute();

            return vratiPrijaveZaProgramTreningaSystemOperation.Prijave;
        }

        internal void KreirajGrupu(Grupa body)
        {
            KreirajGrupuSystemOperation kreirajGrupuSystemOperation = new KreirajGrupuSystemOperation();
            kreirajGrupuSystemOperation.Grupa = body;
            kreirajGrupuSystemOperation.Execute();
        }

        internal void IzmeniGrupu(Grupa body)
        {
            IzmeniGrupuSystemOperation izmeniGrupuSystemOperation = new IzmeniGrupuSystemOperation();
            izmeniGrupuSystemOperation.Grupa = body;
            izmeniGrupuSystemOperation.Execute();
        }
        #endregion
    }
}
