using e_commerce.core.Interfaces;
using e_commerce.Models;
//using Infrasitructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasitructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly Entity _context;
        private readonly DbSet<T> _dbSet; // table name
        public BaseRepository(Entity context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public  async Task<T> GetById(int id)
        {
            return  _dbSet.Find(id);
        }
        public async Task Add(T entity, Action<string> LogAction)
        {
            LogAction?.Invoke($"{typeof(T).Name} Added successfully!");
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public async Task Update(T entity, Action<string> LogAction)
        {
            LogAction?.Invoke($"{typeof(T).Name} Updated successfully!");
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
        public async Task Delete(int id, Action<string> LogAction)
        {
            var item = GetById(id);
            if (item is not null)
            {
                LogAction?.Invoke($"{typeof(T).Name} Deleted successfully!");
                _dbSet.Remove(await item);
                _context.SaveChanges();
            }
            else
            {
                LogAction?.Invoke($"{typeof(T).Name} not found!");
                return;
            }

        }

    }
}