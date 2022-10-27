using LOYMARK.Models;
using LOYMARK.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LOYMARK.Services
{
    public class ActivityService : IActivityService
    {
        readonly IUserRepository userRepository;

        public ActivityService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<ListActivityResponse> GetAllActivity()
        {
            throw new NotImplementedException();
        }

        public void AddActivity(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}
