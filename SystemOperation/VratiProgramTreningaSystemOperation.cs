using Common.Model;

namespace SystemOperation
{
    public class VratiProgramTreningaSystemOperation : SystemOperationBase
    {
        public ProgramTreninga programTreninga { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            programTreninga = (ProgramTreninga)repository.Get(new ProgramTreninga(), $"ProgramTreningaId = {programTreninga.ProgramTreningaId}");
        }
    }
}
