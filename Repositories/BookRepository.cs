using ASP_NET_L3.DAL.Abstracts;
using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _db;

        public BookRepository(AppDbContext db)
        {
            _db = db;
        }

        public bool AddBook(Book book)
        {
            var res = _db.Books.Add(book) != null;
            _db.SaveChanges();
            return res;
        }

        public Book GetById(int id)
        {
            return _db.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return _db.Books.ToList();
        }

        public bool UpdateBook(Book book)
        {
            var existingBook = _db.Books.FirstOrDefault(x => x.Id == book.Id);
            if (existingBook == null)
                return false;

            existingBook.Title = book.Title;
            // ISBN don`t update
            existingBook.PublishYear = book.PublishYear;
            existingBook.Price = book.Price;
            existingBook.AuthorId = book.AuthorId;
            

            _db.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = _db.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return false;

            _db.Books.Remove(book);
            _db.SaveChanges();
            return true;
        }

        public bool BookExistsByISBN(string isbn)
        {
            return _db.Books.Any(b => b.ISBN == isbn);
        }

        public bool BookExistsByISBN(string isbn, int excludeBookId)
        {
            return _db.Books.Any(b => b.ISBN == isbn && b.Id != excludeBookId);
        }

        public bool BookExistsByTitle(string title, int authorId)
        {
            return _db.Books.Any(b => 
                b.Title.ToLower() == title.ToLower() && 
                b.AuthorId == authorId);
        }

        public bool BookExistsByTitle(string title, int authorId, int excludeBookId)
        {
            return _db.Books.Any(b => 
                b.Title.ToLower() == title.ToLower() && 
                b.AuthorId == authorId &&
                b.Id != excludeBookId);
        }
    }
}
