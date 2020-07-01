using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bethany.Data.Repo.IRepositories
{
    public interface IReositorty<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(TEntity entities);
        void Update(TEntity entity);
    }
}
