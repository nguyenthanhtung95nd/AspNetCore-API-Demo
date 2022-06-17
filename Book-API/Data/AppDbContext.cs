using Book_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Book_API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<BookAuthor>()
              .HasOne(b => b.Author)
              .WithMany(ba => ba.BookAuthors)
              .HasForeignKey(bi => bi.AuthorId);

            modelBuilder.Entity<Log>().HasKey(n => n.Id);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
