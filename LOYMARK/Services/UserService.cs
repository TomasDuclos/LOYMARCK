using LOYMARK.Models;
using LOYMARK.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LOYMARK.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetAllUser()
        {
            return userRepository.GetAllUser();
        }

        public User GetUser(int id)
        {
            return userRepository.GetUser(id);
        }

        public List<User> AddUser(User user)
        {
            return userRepository.AddUser(user);
        }

        public List<User> DeleteUser(int id)
        {
            var userOld = userRepository.GetUser(id);

            if (userOld == null)
            {
                throw new Exception("Usuario inexistente");
            }

            return userRepository.DeleteUser(userOld);
        }

        public List<User> UpdateUser(User user)
        {
            var userOld = userRepository.GetUser(user.UserId);

            if (userOld == null)
            {
                throw new Exception("Usuario inexistente");
            }

            userOld.FirtsName = user.FirtsName;
            userOld.LastName= user.LastName;
            userOld.DateBirth = user.DateBirth;
            userOld.Country = user.Country;
            userOld.Mail= user.Mail;
            userOld.Phone = user.Phone;

            return userRepository.UpdateUser(userOld);
        }
    }
}
