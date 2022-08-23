using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly OrcusPersonaContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(OrcusPersonaContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IQueryable<T> AsQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public async Task DeleteAsync(int id) => _dbSet.Remove(await GetByIdAsync(id));

        public async Task DeleteAsync(Expression<Func<T, bool>> where)
        {
            var objects = await GetByConditionAsync(where);
            foreach (var obj in objects)
            {
                _dbSet.Remove(obj);
            }
        }

        public void Dispose()
        {
            _dbContext.DisposeAsync();
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> where) => await _dbSet.Where(where).ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _dbContext.FindAsync<T>(id);

        public Task<PagedModel<T>> GetPagedAsync(PagedModel<T>? pagedModel)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
