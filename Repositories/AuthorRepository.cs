using ASP_NET_L3.DAL.Abstracts;
using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext _db;

        public AuthorRepository(AppDbContext db)
        {
            _db = db;
        }

        public bool AddAuthor(Author author)
        {
            var res = _db.Authors.Add(author) != null;
            _db.SaveChanges();
            return res;
        }

        public Author GetById(int id)
        {
            return _db.Authors.FirstOrDefault(x => x.Id == id);
        }

        public List<Author> GetAll()
        {
            return _db.Authors.ToList();
        }
    }
}
