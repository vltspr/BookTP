using BookTP.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTP
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=BookTP;Username=postgres;Password=neobank");

        public DbSet<Book> Books { get; set; }

        public DbSet<Shelve> Shelves { get; set; }
    }
}
