using System.Collections.Generic;
using System.Threading.Tasks;
using CurriculumStart.API.Models;

namespace CurriculumStart.API.Data
{
    public interface ICurriculumRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}