using LoadoutBuilder.Data;
using LoadoutBuilder.Infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T instance)
        {
            await _dbSet.AddAsync(instance);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(T instance)
        {
            _dbSet.Remove(instance);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var instance = await GetByIdAsync(id);
            await DeleteAsync(instance);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T instance)
        {
            _dbSet.Attach(instance);
            _context.Entry(instance).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task UpdateByIdAsync(int id)
        {
            var instance = await GetByIdAsync(id);
            await UpdateAsync(instance);
        }

    }
}
