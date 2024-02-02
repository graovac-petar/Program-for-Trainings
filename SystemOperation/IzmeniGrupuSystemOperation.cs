using Common.Model;

namespace SystemOperation
{
    public class IzmeniGrupuSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(Grupa, $" grupaid={Grupa.GrupaId}");

            if (Grupa.zaBrisanje.Count > 0)
            {

                foreach (Prijava p in Grupa.zaBrisanje)
                {
                    p.Grupa = null;
                    repository.Update(p, $"prijavazaprogram.programtreningaid={p.ProgramTreninga.ProgramTreningaId} and prijavazaprogram.korisnikid={p.Korisnik.KorisnikId}");
                }

            }
            if (Grupa.zaDodavanje.Count > 0)
            {
                foreach (Prijava p in Grupa.zaDodavanje)
                {
                    p.Grupa = Grupa;
                    repository.Update(p, $"prijavazaprogram.programtreningaid={p.ProgramTreninga.ProgramTreningaId} and prijavazaprogram.korisnikid={p.Korisnik.KorisnikId} ");
                }
            }
        }
    }
}
