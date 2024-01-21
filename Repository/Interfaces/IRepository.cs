using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity, string criteria);
        void Delete(TEntity entity, string criteria);
        TEntity Get(TEntity entity, string criteria);
        List<TEntity> GetAll(TEntity entity);
        List<TEntity> Search(TEntity entity, string criteria);
    }
}
