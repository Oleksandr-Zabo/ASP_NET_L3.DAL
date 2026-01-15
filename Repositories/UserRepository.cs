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
        public void AddUser(User user)
        {
            //throw new NotImplementedException();
            _db.Users.Add(user);
            _db.SaveChanges();
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
