using ASP_NET_L3.DAL.Entities;

namespace ASP_NET_L3.DAL.Abstracts
{
    public interface IUserRepository
    {
        User GetById(int id);

        List<User> GetAll();
        void AddUser(User user);
    }
}
