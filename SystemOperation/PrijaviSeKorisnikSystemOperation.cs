using Common.Model;
using System;

namespace SystemOperation
{
    public class PrijaviSeKorisnikSystemOperation : SystemOperationBase
    {
        public Korisnik Korisnik { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Korisnik k = (Korisnik)repository.Get(Korisnik, $" email='{Korisnik.Email}' and sifra='{Korisnik.Sifra}'");
            if (k == null) throw new Exception("Ne postoji korisnik sa ovim kredencijalima");
            Korisnik = k;
        }
    }
}
