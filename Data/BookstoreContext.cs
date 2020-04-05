using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookxtoreContext> options)
    }
}

            : base(option)
        { }
        public DbSet<Book> Books { get; set; }
        public Dbset<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) =>
        base.OnModelCreating(builder);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<BookAuthor>()
        .Haskey(ba => new { ba.BookId, ba.AuthorId });

        builder.Entity<BookAuthor>()
        .HasOne(ba=>ba.Book)
        .WithMany(ba => b.BookAuthor)
        .HasForeignKey(ba =>ba,BookId);

        builder.Entity<BookAuthor>()
        .HasOne(ba => ba.Author)
        .withMany(a => a.BookAuthor)
        .HasForeignKey(ba => ba.AuthorId);
    }