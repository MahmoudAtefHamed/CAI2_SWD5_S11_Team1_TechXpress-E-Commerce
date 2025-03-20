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
        //private readonly ISiteUserRepository _userRepository;
        private readonly IBaseRepository<Site_User> _userRepository;
        private readonly Action<string> _logAction;

        //public SiteUserService(ISiteUserRepository userRepository)
        public SiteUserService(IBaseRepository<Site_User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Site_User>> GetAllUsers()
        {
            //return await _userRepository.GetAllUsers();
            return await _userRepository.GetAll();
        }

        public async Task<Site_User> GetUserById(int id)
        {
            //return await _userRepository.GetUserById(id);
            return await _userRepository.GetById(id);
        }

        public async Task AddUser(Site_User user)
        {
            // هنا ممكن تعمل Password Hashing قبل الإضافة

            //await _userRepository.AddUser(user);
            await _userRepository.Add(user, _logAction);
        }

        public async Task UpdateUser(Site_User user)
        {
            await _userRepository.Update(user, _logAction);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.Delete(id, _logAction);
        }
    }
}
