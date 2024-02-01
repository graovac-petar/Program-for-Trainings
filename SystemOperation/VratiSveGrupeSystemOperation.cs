using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class VratiSveGrupeSystemOperation : SystemOperationBase
    {
        public List<Grupa> grupe;
        protected override void ExecuteConcreteOperation()
        {
            grupe = repository.GetAll(new Grupa()).Cast<Grupa>().ToList();
        }
    }
}
