using Repository.Implementation;
using System;

namespace SystemOperation
{
    public abstract class SystemOperationBase
    {

        protected GenericDbRepository repository;

        public SystemOperationBase()
        {
            repository = new GenericDbRepository();
        }
        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();

                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw ex;
            }
            finally
            {
                repository.Close();
            }
        }
        protected abstract void ExecuteConcreteOperation();
    }
}
