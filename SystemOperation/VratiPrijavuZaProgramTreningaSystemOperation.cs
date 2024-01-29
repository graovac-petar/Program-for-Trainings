using Common.Model;

namespace SystemOperation
{
    public class VratiPrijavuZaProgramTreningaSystemOperation : SystemOperationBase
    {
        public Prijava Prijava { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Prijava = (Prijava)repository.Get(new Prijava(), $" prijavazaprogram.korisnikid={Prijava.Korisnik.KorisnikId} and prijavazaprogram.programtreningaId={Prijava.ProgramTreninga.ProgramTreningaId}");
        }
    }
}
