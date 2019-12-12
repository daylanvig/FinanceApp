using FinanceApp.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceApp.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(ISpecification<T> spec);
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}