using Microsoft.EntityFrameworkCore.Query;
using Petshop.DAL.DataContext.Entities;
using System.Linq.Expressions;

namespace Petshop.DAL.DataContext.Repositories.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);

        Task<T?> GetAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool asnotracking = false);

        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>>? predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool asnotracking = false);

        Task AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);
    }
}
