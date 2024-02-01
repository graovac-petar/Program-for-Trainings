using Common.Model;

namespace SystemOperation
{
    public class IzmeniProgramTreningaSystemOperation : SystemOperationBase
    {
        public ProgramTreninga programTreninga;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(programTreninga, $" programtreningaId={programTreninga.ProgramTreningaId}");

            if (programTreninga.TreninziZaBrisanje.Count > 0)
            {

                foreach (Trening t in programTreninga.TreninziZaBrisanje)
                {
                    //t.ProgramTreninga = programTreninga;
                    repository.Delete(t, $" trening.treningid={t.TreningId}");
                }

            }
            if (programTreninga.TreninziZaDodavanje.Count > 0)
            {
                foreach (Trening t in programTreninga.TreninziZaDodavanje)
                {
                    t.ProgramTreninga = programTreninga;
                    repository.Add(t);

                }
            }
        }
    }
}
