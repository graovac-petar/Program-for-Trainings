using Common;
using Common.Model;
using Repository.Implementation;
using Repository.Interfaces;
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
    }
}
