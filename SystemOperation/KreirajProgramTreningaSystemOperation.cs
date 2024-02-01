using Common.Model;

namespace SystemOperation
{
    public class KreirajProgramTreningaSystemOperation : SystemOperationBase
    {
        public ProgramTreninga programTreninga;
        protected override void ExecuteConcreteOperation()
        {
            repository.Add(programTreninga);
            foreach (Trening t in programTreninga.TreninziZaDodavanje)
            {
                t.ProgramTreningaId = programTreninga.ProgramTreningaId;
                repository.Add(t);
            }
        }
    }

}
