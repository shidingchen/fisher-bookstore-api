using System.Collections.Generic;
using Fisher.Bookstore.Data;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Services
{

    public class BookRepository : IBooksRepository
    {
        private readonly BookstoreContext db;

        public BookRepository(BookstoreContext db) => this.db = db;

        public Book GetBook(int bookId)
        {
            return db.Books.Find(bookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }
        
        public bool BookExists(int bookId)
        {
            return (db.Books.Find(bookId) != null);
        }

        public int AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return book.Id;
        }

        public void DeleteBook(int bookId)
        {
            db.Books.Remove(db.Books.Find(bookId));
            db.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
        }
    }
}