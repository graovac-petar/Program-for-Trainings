using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiTreningeSystemOperation : SystemOperationBase
    {
        public ProgramTreninga ProgramTreninga { get; set; }
        public List<Trening> listaTreninga { get; set; } = null;
        protected override void ExecuteConcreteOperation()
        {
            if (ProgramTreninga != null)
                listaTreninga = repository.Search(new Trening(), $"trening.programTreningaId={ProgramTreninga.ProgramTreningaId}").Cast<Trening>().ToList();
            else
                listaTreninga = repository.Search(new Trening(), $"trening.programTreningaId=-1").Cast<Trening>().ToList();
        }
    }
}
