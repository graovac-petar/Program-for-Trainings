using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiPrijaveZaProgramTreningaSystemOperation : SystemOperationBase
    {
        public ProgramTreninga ProgramTreninga;
        public List<Prijava> Prijave;
        protected override void ExecuteConcreteOperation()
        {
            Prijave = repository.Search(new Prijava(), $"prijavazaprogram.programtreningaid={ProgramTreninga.ProgramTreningaId} and g.grupaid is null").Cast<Prijava>().ToList();
        }
    }
}
