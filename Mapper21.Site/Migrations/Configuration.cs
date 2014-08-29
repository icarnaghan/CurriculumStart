using System.Data.Entity.Migrations;
using System.Linq;
using Mapper21.Site.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mapper21.Site.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
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

            if (!context.Roles.Any(r => r.Name == "Support"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Support" };
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

            // Administrators
            if (!context.Users.Any(u => u.UserName == "ian@carnaghan.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "ian@carnaghan.com", Email = "ian@carnaghan.com" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "Nobler@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Nobler@monarchcharter.org", Email = "Nobler@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "rpittman@elschools.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "rpittman@elschools.org", Email = "rpittman@elschools.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
                manager.AddToRole(user.Id, "Admin");
            }

            // Cultural Arts
            if (!context.Users.Any(u => u.UserName == "alexanderc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "alexanderc@monarchcharter.org", Email = "alexanderc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "brownda@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "brownda@monarchcharter.org", Email = "brownda@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "drenners@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "drenners@monarchcharter.org", Email = "drenners@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "Fernandezm@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Fernandezm@monarchcharter.org", Email = "Fernandezm@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "greensa@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "greensa@monarchcharter.org", Email = "greensa@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "mendelj@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "mendelj@monarchcharter.org", Email = "mendelj@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "pausleyr@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "pausleyr@monarchcharter.org", Email = "pausleyr@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "baldwink@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "baldwink@monarchcharter.org", Email = "baldwink@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            // Support Staff
            if (!context.Users.Any(u => u.UserName == "ackleys@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "ackleys@monarchcharter.org", Email = "ackleys@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "brownl@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "brownl@monarchcharter.org", Email = "brownl@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "crankfieldd@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "crankfieldd@monarchcharter.org", Email = "crankfieldd@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "czajkowskic@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "czajkowskic@monarchcharter.org", Email = "czajkowskic@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "deritterm@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "deritterm@monarchcharter.org", Email = "deritterm@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "echarde@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "echarde@monarchcharter.org", Email = "echarde@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "greens@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "greens@monarchcharter.org", Email = "greens@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "griffthd@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "griffthd@monarchcharter.org", Email = "griffthd@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "HallM@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "HallM@monarchcharter.org", Email = "HallM@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "harmonc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "harmonc@monarchcharter.org", Email = "harmonc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "kislingb@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "kislingb@monarchcharter.org", Email = "kislingb@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "monroej@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "monroej@monarchcharter.org", Email = "monroej@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "moorej@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "moorej@monarchcharter.org", Email = "moorej@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "oxyerk@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "oxyerk@monarchcharter.org", Email = "oxyerk@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "monarchapplication@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "monarchapplication@monarchcharter.org", Email = "monarchapplication@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "russellL@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "russellL@monarchcharter.org", Email = "russellL@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "walker@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "walker@monarchcharter.org", Email = "walker@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "changeindismissalplan@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "changeindismissalplan@monarchcharter.org", Email = "changeindismissalplan@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "weaverc@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "weaverc@monarchcharter.org", Email = "weaverc@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            if (!context.Users.Any(u => u.UserName == "zazzeraa@monarchcharter.org"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "zazzeraa@monarchcharter.org", Email = "zazzeraa@monarchcharter.org" };

                manager.Create(user, "111111");
                manager.AddToRole(user.Id, "Support");
            }

            // Grade Level Teachers
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
