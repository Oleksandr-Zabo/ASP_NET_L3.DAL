using ASP_NET_L3.DAL.Abstracts;
using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Repositories
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly AppDbContext _db;

        public AuthorRepository( AppDbContext db)
        {
            _db = db;
        }

        public void AddAuthor(Author author)
        {
            _db.Authors.Add(author);
            _db.SaveChanges();
        }

        public Author GetById(int id)
        {
            return _db.Authors.FirstOrDefault(x => x.Id == id);
        }

        public List<Author> GetAll()
        {
            return _db.Authors.ToList();
        }

        public bool AuthorExists(string firstName, string lastName, DateTime birthDate)
        {
            return _db.Authors.Any(a => 
                a.FirstName.ToLower() == firstName.ToLower() && 
                a.LastName.ToLower() == lastName.ToLower() && 
                a.BirthDate.Date == birthDate.Date);
        }
    }
}
