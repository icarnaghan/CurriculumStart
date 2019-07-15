using System.Linq;
using CurriculumStart.API.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace CurriculumStart.API.Data
{
    public class Seed
    {
        private readonly UserManager<User> _userManager;
        public Seed(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public void SeedUsers()
        {
            if (!_userManager.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<System.Collections.Generic.List<User>>(userData);
                foreach (var user in users)
                {
                    _userManager.CreateAsync(user, "password").Wait();
                }
            }
        }
    }
}