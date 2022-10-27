using LOYMARK.Models;

namespace LOYMARK.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetAllUser();
        public User GetUser(int id);
        public List<User> AddUser(User user);
        public List<User> UpdateUser(User user);
        public List<User> DeleteUser(User user);
    }
}
