using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiTreningeSystemOperation : SystemOperationBase
    {
        public ProgramTreninga ProgramTreninga { get; set; }
        public List<Trening> listaTreninga { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            listaTreninga = repository.Search(new Trening(), $"trening.programTreningaId={ProgramTreninga.ProgramTreningaId}").Cast<Trening>().ToList();
        }
    }
}
