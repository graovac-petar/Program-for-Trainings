using Common.Model;

namespace SystemOperation
{
    public class PosaljiPrijavuZaProgramTreningaSystemOperation : SystemOperationBase
    {
        public Prijava prijava;
        protected override void ExecuteConcreteOperation()
        {
            repository.Add(prijava);
        }
    }
}
