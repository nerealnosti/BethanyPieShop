using Bethany.Data.Repo.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoodGood.Data.Repositories
{
    public class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity>
        where TEntity : class
    {
        private readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbentities;

        public RepositoryAsync(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbentities = _dbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbentities.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbentities.AddRangeAsync(entities);
        }

        public async Task<int> Commit()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(_dbentities.Where(predicate));
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Task.FromResult(_dbentities.AsEnumerable());
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbentities.FindAsync(id);
        }

        public async Task RemoveEntityAsync(TEntity entity)
        {
            await Task.FromResult(_dbentities.Remove(entity));
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _dbentities.RemoveRange(entities));
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbentities.SingleOrDefaultAsync(predicate);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.FromResult(_dbentities.Update(entity));
        }


        public async Task<IEnumerable<TEntity>> GetIncludes(params Expression<Func<TEntity, Object>>[] includes)
        {
            IQueryable<TEntity> query = _dbentities;
            foreach(var include in includes.Skip(1))
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();

        }

        public async Task<TEntity> GetIncludesSingleWithID( Func<TEntity, bool> predicate, params Expression<Func<TEntity, Object>>[] includes)
        {

            return await Task.Run(()=>
            {
                IQueryable<TEntity> query = _dbentities;
                foreach(var include in includes)
                {
                    query = query.Include(include);
                }
                return query.SingleOrDefault(predicate);

            });
            

        }


      


    }
}
