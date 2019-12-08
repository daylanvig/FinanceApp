using FinanceApp.Models.Entities;
using FinanceApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Data
{
    public class Repository<T> : IAsyncRepository<T> where T : BaseEntity
    {

        protected readonly DataContext _dbContext;

        private DbSet<T> _items;
        public Repository(DataContext dbContext)
        {
            _dbContext = dbContext;
            _items = dbContext.Set<T>();
        }
        public virtual async Task<T> GetAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _items.FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _items.ToListAsync().ConfigureAwait(false);
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync().ConfigureAwait(false);
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync().ConfigureAwait(false);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _items.AddAsync(entity);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);

            return entity;
        }
        
        public async Task<bool> AnyAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).AnyAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(T entity)
        {
            _items.Remove(entity);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }


    }
}