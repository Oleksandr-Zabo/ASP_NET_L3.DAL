using ASP_NET_L3.DAL.Abstracts;
using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
            //dependency injection

        }
        public bool AddUser(User user)
        {
            var res = _db.Users.Add(user) != null;
            _db.SaveChanges();

            return res;
        }

        public User GetById(int id)
        {
            return _db.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetAll() { 
            return _db.Users.ToList();
        }
    }
}
