using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Abstracts
{
    public interface IBookRepository
    {
        Book GetById(int id);
        List<Book> GetAll();
        bool AddBook(Book book);
        bool BookExistsByISBN(string isbn);
        bool BookExistsByTitle(string title, int authorId);
    }
}
