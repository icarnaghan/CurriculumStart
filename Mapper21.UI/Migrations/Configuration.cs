using Mapper21.UI.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mapper21.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mapper21.UI.Identity.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Mapper21.UI.Identity.ApplicationDbContext context)
        {
            // Populate User Roles
            if (!context.Roles.Any(r => r.Name == "Kindergarten"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Kindergarten" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "FirstGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "FirstGrade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "SecondGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "SecondGrade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "ThirdGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "ThirdGrade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "FourthGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "FourthGrade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "FifthGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "FifthGrade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "SixthGrade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "SixthGrade" };
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
                var user = new ApplicationUser { UserName = "kindergarten" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "firstgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "firstgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "FirstGrade");
            }

            if (!context.Users.Any(u => u.UserName == "secondgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "secondgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "SecondGrade");
            }

            if (!context.Users.Any(u => u.UserName == "thirdgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "thirdgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "ThirdGrade");
            }

            if (!context.Users.Any(u => u.UserName == "forthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fourthgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "FourthGrade");
            }

            if (!context.Users.Any(u => u.UserName == "fifthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fifthgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "FifthGrade");
            }

            if (!context.Users.Any(u => u.UserName == "sixthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "sixthgrade" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "SixthGrade");
            }
        }
    }
}
