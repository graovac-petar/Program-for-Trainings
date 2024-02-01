using Common.Model;

namespace SystemOperation
{
    public class ObrisiProgramTreningaSystemOperation : SystemOperationBase
    {
        public ProgramTreninga programTreninga;
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(programTreninga, $" programtreningaId={programTreninga.ProgramTreningaId}");
        }
    }
}
