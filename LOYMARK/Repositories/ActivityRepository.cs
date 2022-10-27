using LOYMARK.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LOYMARK.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly LoymarkContext dbContext;

        public ActivityRepository(LoymarkContext dbContext)
        {
            this.dbContext = dbContext;   
        }

        public List<ListActivityResponse> GetAllActivity()
        {
            //var listActivityResponse = (from activity in dbContext.Activity
            //                            join user in dbContext.User
            //                               on activity.UserId equals user.UserId
            //                            select new List<ListActivityResponse>()
            //                            {

            //                                activity.CreateDate,user.FirtsName,activity.Description
            //                            }).ToList();

            return null;
        }

        public void AddActivity(User user)
        {
            dbContext.User.Add(user);

            dbContext.SaveChanges();
        }

        private IQueryable<Activity> GetQuery()
        {
            return dbContext.Activity;
        }

        public void AddActivity(Activity activity)
        {
            dbContext.Activity.Add(activity);

            dbContext.SaveChanges();
        }
    }
}
