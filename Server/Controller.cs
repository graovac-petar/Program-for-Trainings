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

        public Korisnik KorisnikPrijavljivanje(Korisnik kor)
        {
            PrijaviSeKorisnikSystemOperation prijaviSeKorisnikSystemOperation = new PrijaviSeKorisnikSystemOperation();
            prijaviSeKorisnikSystemOperation.Korisnik = kor;
            prijaviSeKorisnikSystemOperation.Execute();

            return prijaviSeKorisnikSystemOperation.Korisnik;
        }
    }
}
