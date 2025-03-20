using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.core.Interfaces;
using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Infrastructure.Repositories
{
    public class SiteUserRepository : ISiteUserRepository
    {
        private readonly Entity _context = new Entity();

        public SiteUserRepository(Entity context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Site_User>> GetAllUsers()
        {
            return await _context.SiteUsers.ToListAsync();
        }

        public async Task<Site_User> GetUserById(int id)
        {
            return await _context.SiteUsers.FirstOrDefaultAsync(u=>u.Id == id);
        }

        public async Task AddUser(Site_User user)
        {
            await _context.SiteUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(Site_User user)
        {
            _context.SiteUsers.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _context.SiteUsers.FirstOrDefaultAsync(e=>e.Id == id);
            if (user != null)
            {
                _context.SiteUsers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }


    }
}
