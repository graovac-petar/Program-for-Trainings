using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiSveProgrameTreningaSystemOperation : SystemOperationBase
    {
        public List<ProgramTreninga> programiTreninga { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            programiTreninga = repository.GetAll(new ProgramTreninga()).Cast<ProgramTreninga>().ToList();
        }
    }
}
