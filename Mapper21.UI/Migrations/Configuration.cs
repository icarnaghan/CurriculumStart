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

            if (!context.Roles.Any(r => r.Name == "Seventh Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Seventh Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Eigth Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Eigth Grade" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Ninth Grade"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Ninth Grade" };
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
                var user = new ApplicationUser { UserName = "kindergarten@monarchcharter.org", Email = "kindergarten@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "firstgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "firstgrade@monarchcharter.org", Email = "firstgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "secondgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "secondgrade@monarchcharter.org", Email = "secondgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Second Grade");
            }

            if (!context.Users.Any(u => u.UserName == "thirdgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "thirdgrade@monarchcharter.org", Email = "thirdgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "forthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fourthgrade@monarchcharter.org", Email = "fourthgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "fifthgrade"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "fifthgrade@monarchcharter.org", Email = "fifthgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "sixthgrade@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "sixthgrade@monarchcharter.org", Email = "sixthgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "seventhgrade@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "seventhgrade@monarchcharter.org", Email = "seventhgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Seventh Grade");
            }

            if (!context.Users.Any(u => u.UserName == "eighthgrade@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "eighthgrade@monarchcharter.org", Email = "eigthgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "ninthgrade@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "ninthgrade@monarchcharter.org", Email = "ninthgrade@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Ninth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "clemsons@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "clemsons@monarchcharter.org", Email = "clemsons@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "beverlyg@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "beverlyg@monarchcharter.org", Email = "beverlyg@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "koelbels@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "koelbels@monarchcharter.org", Email = "koelbels@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Kindergarten");
            }

            if (!context.Users.Any(u => u.UserName == "behrh@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "behrh@monarchcharter.org", Email = "behrh@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "greenbergk@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "greenbergk@monarchcharter.org", Email = "greenbergk@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "williamsc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "williamsc@monarchcharter.org", Email = "williamsc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "oyinlolac@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "oyinlolac@monarchcharter.org", Email = "oyinlolac@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "First Grade");
            }

            if (!context.Users.Any(u => u.UserName == "bolotins@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "bolotins@monarchcharter.org", Email = "bolotins@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Second Grade");
            }

            if (!context.Users.Any(u => u.UserName == "hammelj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "hammelj@monarchcharter.org", Email = "hammelj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Second Grade");
            }

            if (!context.Users.Any(u => u.UserName == "lanmank@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "lanmank@monarchcharter.org", Email = "lanmank@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Second Grade");
            }

            if (!context.Users.Any(u => u.UserName == "higginsa@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "higginsa@monarchcharter.org", Email = "higginsa@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "stevenae@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "stevenae@monarchcharter.org", Email = "stevenae@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "valentas@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "valentas@monarchcharter.org", Email = "valentas@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "harboldl@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "harboldl@monarchcharter.org", Email = "harboldl@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Third Grade");
            }

            if (!context.Users.Any(u => u.UserName == "turcottem@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "turcottem@monarchcharter.org", Email = "turcottem@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "uddemet@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "uddemet@monarchcharter.org", Email = "uddemet@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "wollschlagerj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "wollschlagerj@monarchcharter.org", Email = "wollschlagerj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "brayl@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "brayl@monarchcharter.org", Email = "brayl@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fourth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "brunek@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "brunek@monarchcharter.org", Email = "brunek@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "hyltont@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "hyltont@monarchcharter.org", Email = "hyltont@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "pindera@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "pindera@monarchcharter.org", Email = "pindera@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "dunaways@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "dunaways@monarchcharter.org", Email = "dunaways@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Fifth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "franklinc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "franklinc@monarchcharter.org", Email = "franklinc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "friedmanj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "friedmanj@monarchcharter.org", Email = "friedmanj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "graverh@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "graverh@monarchcharter.org", Email = "graverh@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "andersonb@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "andersonb@monarchcharter.org", Email = "andersonb@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Sixth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "jessilonist@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "jessilonist@monarchcharter.org", Email = "jessilonist@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Seventh Grade");
            }

            if (!context.Users.Any(u => u.UserName == "millers@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "millers@monarchcharter.org", Email = "millers@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Seventh Grade");
            }

            if (!context.Users.Any(u => u.UserName == "peownl@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "peownl@monarchcharter.org", Email = "peownl@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Seventh Grade");
            }

            if (!context.Users.Any(u => u.UserName == "deanm@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "deanm@monarchcharter.org", Email = "deanm@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Seventh Grade");
            }

            if (!context.Users.Any(u => u.UserName == "bennettj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "bennettj@monarchcharter.org", Email = "bennettj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "dieffenbacherj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "dieffenbacherj@monarchcharter.org", Email = "dieffenbacherj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "gonczg@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "gonczg@monarchcharter.org", Email = "gonczg@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "wrightc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "wrightc@monarchcharter.org", Email = "wrightc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }

            if (!context.Users.Any(u => u.UserName == "schumachers@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "schumachers@monarchcharter.org", Email = "schumachers@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Eigth Grade");
            }
        }
    }
}
