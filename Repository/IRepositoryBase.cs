using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryBase<T>: IDisposable where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<PagedModel<T>> GetPagedAsync(PagedModel<T>? pagedModel);
        Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> where);
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task DeleteAsync(Expression<Func<T, bool>> where);
        IQueryable<T> AsQueryable();
        Task SaveAsync();
        Task RollbackAsync();
    }
}
