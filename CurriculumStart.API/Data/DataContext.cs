using CurriculumStart.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CurriculumStart.API.Data
{
    public class DataContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMap>()
                .HasKey(bc => new { bc.UserId, bc.MapId });  
            modelBuilder.Entity<UserMap>()
                .HasOne(bc => bc.Users)
                .WithMany(b => b.UserMaps)
                .HasForeignKey(bc => bc.UserId);  
            modelBuilder.Entity<UserMap>()
                .HasOne(bc => bc.Maps)
                .WithMany(c => c.UserMaps)
                .HasForeignKey(bc => bc.MapId);
        }
        public DataContext(DbContextOptions<DataContext> options): base (options) {}
        public DbSet<Value> Values { get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<UserMap> UserMaps { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
