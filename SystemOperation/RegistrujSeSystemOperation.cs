using Common.Model;

namespace SystemOperation
{
    public class RegistrujSeSystemOperation : SystemOperationBase
    {
        public Korisnik Korisnik { get; set; }

        public void RegistrujKorisnika(Korisnik k)
        {
            Korisnik = k;
        }

        protected override void ExecuteConcreteOperation()
        {

            repository.Add(Korisnik);

        }
    }
}
