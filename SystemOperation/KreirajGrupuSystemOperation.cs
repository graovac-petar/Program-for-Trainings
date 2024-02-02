using Common.Model;
using System;

namespace SystemOperation
{
    public class KreirajGrupuSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        protected override void ExecuteConcreteOperation()
        {
            repository.Add(Grupa);

            if (Grupa.GrupaId == 0) throw new Exception("Greska u dodavanju grupe");
            foreach (Prijava p in Grupa.zaDodavanje)
            {
                p.Grupa = Grupa;

                repository.Update(p, $"prijavazaprogram.programtreningaid={p.ProgramTreninga.ProgramTreningaId} and prijavazaprogram.korisnikid={p.Korisnik.KorisnikId} ");
            }
        }
    }
}
