using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiPrijaveVanGrupeSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        public List<Prijava> prijave;
        protected override void ExecuteConcreteOperation()
        {
            prijave = repository.Search(new Prijava(), $"prijavazaprogram.GrupaId is NULL and prijavazaprogram.programtreningaid={Grupa.ProgramTreninga.ProgramTreningaId}").Cast<Prijava>().ToList();
        }
    }
}
