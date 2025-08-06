using LoadoutBuilder.Data;
using LoadoutBuilder.Data.Models.Contracts;
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

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public IQueryable<T> GetAllAttached()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> SoftDeleteAsync<T>(T instance) where T : class,ISoftDeletable
        {
            if (instance.IsDeleted == true)
            {
                return false;
            }
            instance.IsDeleted = true;
            return await UpdateByIdAsync(instance.Id);
        }

        public async Task UpdateAsync(T instance)
        {
            _dbSet.Attach(instance);
            _context.Entry(instance).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateByIdAsync(int id)
        {
            try
            {
                var instance = await GetByIdAsync(id);
                _dbSet.Attach(instance);
                _context.Entry(instance).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
