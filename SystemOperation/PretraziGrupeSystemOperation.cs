using Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperation
{
    public class PretraziGrupeSystemOperation : SystemOperationBase
    {
        public Grupa grupa;
        public List<Grupa> grupe;
        protected override void ExecuteConcreteOperation()
        {
            grupe = repository.Search(grupa, grupa.SearchQuery).Cast<Grupa>().ToList();
        }
    }
}
