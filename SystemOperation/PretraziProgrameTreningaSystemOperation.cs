using Common.Model;
using System.Collections.Generic;
using System.Linq;
using SystemOperation;

namespace Server
{
    public class PretraziProgrameTreningaSystemOperation : SystemOperationBase
    {
        public List<ProgramTreninga> listaprogramaTreninga;
        public ProgramTreninga programTreninga;
        protected override void ExecuteConcreteOperation()
        {
            listaprogramaTreninga = repository.Search(programTreninga, programTreninga.SearchQuery).Cast<ProgramTreninga>().ToList();
        }
    }
}
