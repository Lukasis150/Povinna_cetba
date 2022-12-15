using Microsoft.EntityFrameworkCore;
using Povinna_cetba.Models;

namespace Povinna_cetba.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentBooksLink>()
                .HasKey(link => new { link.StudentlId, link.BookId });

            modelBuilder.Entity<StudentBooksLink>()
                .HasOne(link => link.Student)
                .WithMany(student => student.BookLinks)
                .HasForeignKey(link => link.StudentlId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentBooksLink>()
                .HasOne(link => link.Book)
                .WithMany(book => book.StudentLinks)
                .HasForeignKey(link => link.BookId)
                .OnDelete(DeleteBehavior.Restrict); ;

            modelBuilder.Entity<BookGenresLink>()
                .HasKey(link => new { link.BooklId, link.GenreId });

            modelBuilder.Entity<BookGenresLink>()
                .HasOne(link => link.Book)
                .WithMany(book => book.GenreLinks)
                .HasForeignKey(link => link.BooklId)
                .OnDelete(DeleteBehavior.Restrict); ;

            modelBuilder.Entity<BookGenresLink>()
                .HasOne(link => link.Genre)
                .WithMany(genre => genre.BookLinks)
                .HasForeignKey(link => link.GenreId)
                .OnDelete(DeleteBehavior.Restrict); ;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentBooksLink> StudentBooksLinks { get; set; }
        public DbSet<BookGenresLink> BookGenresLinks { get; set; }
    }
}
