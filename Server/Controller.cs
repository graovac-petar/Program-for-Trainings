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
        #endregion ProgramTreninga
        #region Treninge
        internal List<Trening> VratiTreninge(ProgramTreninga body)
        {
            VratiTreningeSystemOperation vratiTreningeSystemOperation = new VratiTreningeSystemOperation();
            vratiTreningeSystemOperation.ProgramTreninga = body;
            vratiTreningeSystemOperation.Execute();

            return vratiTreningeSystemOperation.listaTreninga;
        }
        #endregion

        #region Treninge
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
        #endregion
    }
}
