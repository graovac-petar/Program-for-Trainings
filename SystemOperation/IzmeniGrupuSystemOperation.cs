using Common.Model;

namespace SystemOperation
{
    public class IzmeniGrupuSystemOperation : SystemOperationBase
    {
        public Grupa Grupa;
        protected override void ExecuteConcreteOperation()
        {
            repository.Update(Grupa, $" idgrupe='{Grupa.GrupaId}'");

            if (Grupa.zaBrisanje.Count > 0)
            {

                foreach (Prijava p in Grupa.zaBrisanje)
                {
                    repository.Update(p, $"prijavazaprogram.grupaid=NULL");
                }

            }
            if (Grupa.zaDodavanje.Count > 0)
            {
                foreach (Prijava p in Grupa.zaDodavanje)
                {
                    p.Grupa = Grupa;
                    repository.Update(p, $"prijavazaprogram.grupaid={Grupa.GrupaId}");
                }
            }
        }
    }
}
