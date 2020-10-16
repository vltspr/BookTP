using BookTP.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Extensions;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasIndex(p => p.SearchVector)
                .HasMethod("GIN");
        }


        public DbSet<Book> Books { get; set; }

        public DbSet<Shelve> Shelves { get; set; }
    }
}
