using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.core.Interfaces;
using e_commerce.Models;
using e_commerce.Service.Interfaces;

namespace e_commerce.Service.Services
{
    public class SiteUserService:ISiteUserService
    {
        private readonly ISiteUserRepository _userRepository;

        public SiteUserService(ISiteUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Site_User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<Site_User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task AddUser(Site_User user)
        {
            // هنا ممكن تعمل Password Hashing قبل الإضافة
            await _userRepository.AddUser(user);
        }

        public async Task UpdateUser(Site_User user)
        {
            await _userRepository.UpdateUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
        }
    }
}
