using Data.Modules;

using Microsoft.EntityFrameworkCore;

namespace Data.EfDbContext
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server=(localdb)\mssqllocaldb;
            Database=BlazorEfCpreSample;
            Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}
