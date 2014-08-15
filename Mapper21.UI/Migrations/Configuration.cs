using Mapper21.UI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mapper21.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mapper21.UI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Mapper21.UI.Models.ApplicationDbContext context)
        {
            // Populate User Roles
            if (!context.Roles.Any(r => r.Name == "Kindergarten"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Kindergarten" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "First Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "First Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Second Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Second Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Third Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Third Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Fourth Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Fourth Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Fifth Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Fifth Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Sixth Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Sixth Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }

            // Populate User Accounts
            if (!context.Users.Any(u => u.UserName == "admin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "kindergarten"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "kindergarten@monarchcharter.edu", Email = "kindergarten@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "firstgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "firstgrade@monarchcharter.edu", Email = "firstgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "secondgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "secondgrade@monarchcharter.edu", Email = "secondgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Second Grade");
            }

            if (!context.Users.Any(u => u.UserName == "thirdgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "thirdgrade@monarchcharter.edu", Email = "thirdgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "forthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fourthgrade@monarchcharter.edu", Email = "fourthgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "fifthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fifthgrade@monarchcharter.edu", Email = "fifthgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "sixthgrade@monarchcharter.edu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "sixthgrade", Email = "sixthgrade@monarchcharter.edu" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }
        }
    }
}
