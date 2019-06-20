using CurriculumStart.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CurriculumStart.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) {}
        public DbSet<Value> Values { get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}