    using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Abstracts
{
    public interface IBookRepository
    {
        Book GetById(int id);
        List<Book> GetAll();
        bool AddBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(int id);
        bool BookExistsByISBN(string isbn);
        bool BookExistsByISBN(string isbn, int excludeBookId);
        bool BookExistsByTitle(string title, int authorId);
        bool BookExistsByTitle(string title, int authorId, int excludeBookId);
    }
}
