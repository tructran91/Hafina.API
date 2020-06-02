using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hafina.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Query(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        IQueryable<TEntity> Query(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        TEntity GetById(int id);

        Task<TEntity> GetByIdAsync(int id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);

        void Update(TEntity entityToUpdate);

        void DeleteById(int id);

        void Delete(TEntity entityToDelete);

        void Commit();

        Task CommitAsync();
    }
}
