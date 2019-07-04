using System.Collections.Generic;
using System.Threading.Tasks;
using CurriculumStart.API.Helpers;
using CurriculumStart.API.Models;

namespace CurriculumStart.API.Data
{
    public interface ICurriculumRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
    }
}