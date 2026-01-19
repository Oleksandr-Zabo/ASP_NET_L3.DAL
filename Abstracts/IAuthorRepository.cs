using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Abstracts
{
    public interface IAuthorRepository
    {
        bool AddAuthor(Author author);
        Author GetById(int id);
        List<Author> GetAll();
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(int id);
        bool HasBooks(int authorId);
    }
}