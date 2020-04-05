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
