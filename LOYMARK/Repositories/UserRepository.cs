using LOYMARK.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LOYMARK.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LoymarkContext dbContext;

        public UserRepository(LoymarkContext dbContext)
        {
            this.dbContext = dbContext;   
        }

        public List<User> GetAllUser()
        {
            return GetQuery().ToList();
        }

        public User GetUser(int id)
        {
            return GetQuery().Where(x => x.UserId == id).FirstOrDefault();
        }

        public List<User> DeleteUser(User user)
        {
            dbContext.User.Remove(user);
            dbContext.SaveChanges();

            return GetAllUser();
        }

        public List<User> AddUser(User user)
        {
            dbContext.User.Add(user);

            dbContext.SaveChanges();

            return GetAllUser();
        }

        public List<User> UpdateUser(User user)
        {
            dbContext.SaveChanges();

            return GetAllUser();
        }

        private IQueryable<User> GetQuery()
        {
            return dbContext.User;
        }
    }
}
