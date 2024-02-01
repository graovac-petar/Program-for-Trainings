using Common.Model;

namespace SystemOperation
{
    public class VratiGrupuSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        protected override void ExecuteConcreteOperation()
        {
            Grupa = (Grupa)repository.Get(new Grupa(), $"grupa.Grupaid={Grupa.GrupaId}");
        }
    }
}
