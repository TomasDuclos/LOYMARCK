using LOYMARK.Models;

namespace LOYMARK.Services
{
    public interface IUserService
    {
        public List<User> GetAllUser();
        public User GetUser(int id);
        public List<User> AddUser(User user);
        public List<User> UpdateUser(User user);
        public List<User> DeleteUser(int id);
    }
}
