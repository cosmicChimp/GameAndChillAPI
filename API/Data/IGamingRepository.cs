using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IGamingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}
