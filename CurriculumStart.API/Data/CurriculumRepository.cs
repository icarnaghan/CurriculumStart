using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurriculumStart.API.Helpers;
using CurriculumStart.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CurriculumStart.API.Data
{
    public class CurriculumRepository : ICurriculumRepository
    {
        private readonly DataContext _context;
        public CurriculumRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<UserFollow> GetFollow(int userId, int recipientId)
        {
            return await _context.UserFollows.FirstOrDefaultAsync(u => 
                u.FollowerId == userId && u.FolloweeId == recipientId);
        }

        public async Task<Photo> GetMainPhotoForUser(int userId)
        {
            return await _context.Photos.Where(u => u.UserId == userId).FirstOrDefaultAsync(p => p.IsMain);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            
            return photo;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = _context.Users.Include(p => p.Photos).OrderByDescending(u => u.LastActive).AsQueryable();

            users = users.Where(u => u.Id != userParams.UserId);

            users = users.Where(u => u.Gender == userParams.Gender);

            if (userParams.Followers)
            {
                var userFollowers = await GetUserFollows(userParams.UserId, userParams.Followers);
                users = users.Where(u => userFollowers.Contains(u.Id));
            }

            if (userParams.Followees)
            {
                var userFollowees = await GetUserFollows(userParams.UserId, userParams.Followers);
                users = users.Where(u => userFollowees.Contains(u.Id));
            }

            if (userParams.MinAge != 18 || userParams.MaxAge != 99)
            {
                var minDob = DateTime.Today.AddYears(-userParams.MaxAge - 1);
                var maxDob = DateTime.Today.AddYears(-userParams.MinAge);

                users = users.Where(u => u.DateOfBirth >= minDob && u.DateOfBirth <= maxDob);
            }

            if (!string.IsNullOrEmpty(userParams.OrderBy))
            {
                switch (userParams.OrderBy)
                {
                    case "created": users = users.OrderByDescending(u => u.Created);
                    break;
                    default: users = users.OrderByDescending(u => u.LastActive);
                    break;
                }
            }

            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        private async Task<IEnumerable<int>> GetUserFollows(int id, bool followers)
        {
            var user = await _context.Users
                .Include(x => x.Followers)
                .Include(x => x.Followees)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (followers)
            {
                return user.Followers.Where(u => u.FolloweeId == id).Select(i => i.FollowerId);
            }
            else
            {
                return user.Followees.Where(u => u.FollowerId == id).Select(i => i.FolloweeId);
            }

        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}