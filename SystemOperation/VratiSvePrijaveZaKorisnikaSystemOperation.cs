using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiSvePrijaveZaKorisnikaSystemOperation : SystemOperationBase
    {
        public List<Prijava> listaPrijava;
        public Korisnik korisnik;
        protected override void ExecuteConcreteOperation()
        {
            listaPrijava = repository.Search(new Prijava(), $"prijavazaprogram.korisnikId={korisnik.KorisnikId}").Cast<Prijava>().ToList();
        }
    }
}
