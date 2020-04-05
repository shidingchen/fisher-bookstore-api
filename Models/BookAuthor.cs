using System.Collections.Generic;

namespace Fisher.Bookstore.Models
{
    public class BooksAuthor
    {
        public int BookId{ get;get; }
        public Book Book{ get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}