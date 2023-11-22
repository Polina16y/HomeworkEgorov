using Microsoft.EntityFrameworkCore;

namespace Homework
{
    internal class YourDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Smeshariki;Trusted_Connection=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Count> Count { get; set; }

    }

}
