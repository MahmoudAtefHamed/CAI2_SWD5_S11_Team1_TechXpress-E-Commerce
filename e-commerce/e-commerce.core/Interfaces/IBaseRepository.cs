using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Models;

namespace e_commerce.core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T user, Action<string> LogAction);
        Task Update(T user, Action<string> LogAction);
        Task Delete(int id, Action<string> LogAction);
    }
}
