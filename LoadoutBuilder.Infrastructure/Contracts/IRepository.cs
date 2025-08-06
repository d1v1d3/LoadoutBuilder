using LoadoutBuilder.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Infrastructure.Contracts
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAllAttached();
        Task AddAsync(T instance);
        Task UpdateAsync(T instance);
        Task<bool> UpdateByIdAsync(int id);
        Task<bool> SoftDeleteAsync<T>(T instance) where T : class,ISoftDeletable;
    }
}
