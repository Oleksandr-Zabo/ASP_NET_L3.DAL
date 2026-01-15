using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Abstracts
{
    public interface IAuthorRepository
    {
        Author GetById(int id);
        List<Author> GetAll();
        void AddAuthor(Author author);
        bool AuthorExists(string firstName, string lastName, DateTime birthDate);
    }
}
