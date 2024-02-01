using Common.Model;

namespace SystemOperation
{

    public class ObrisiGrupuSystemOperation : SystemOperationBase
    {
        public Grupa grupa;
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(grupa, $" grupaid={grupa.GrupaId}");
        }
    }
}
