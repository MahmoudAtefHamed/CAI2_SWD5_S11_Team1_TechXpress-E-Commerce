using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Models;

namespace e_commerce.Service.Interfaces
{
    public interface ISiteUserService
    {
        Task<IEnumerable<Site_User>> GetAllUsers();
        Task<Site_User> GetUserById(int id);
        Task AddUser(Site_User user);
        Task UpdateUser(Site_User user);
        Task DeleteUser(int id);
    }
}
