using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiPrijavaZaGrupuSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        public List<Prijava> prijave;
        protected override void ExecuteConcreteOperation()
        {
            prijave = repository.Search(new Prijava(), $"prijavazaprogram.GrupaId={Grupa.GrupaId}").Cast<Prijava>().ToList();
        }
    }
}
