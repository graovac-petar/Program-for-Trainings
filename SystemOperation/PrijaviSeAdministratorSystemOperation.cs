using Common.Model;
using System;

namespace SystemOperation
{
    public class PrijaviSeAdministratorSystemOperation : SystemOperationBase
    {
        public Administrator Administrator { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Administrator a = (Administrator)repository.Get(Administrator, $" korisnickoime='{Administrator.KorisnickoIme}' and sifra='{Administrator.Sifra}'");
            if (a == null) throw new Exception("Ne postoji administrator sa ovakvim kredencijalima");
            Administrator = a;
        }
    }
}
