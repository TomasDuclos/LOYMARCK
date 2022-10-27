using LOYMARK.Models;

namespace LOYMARK.Repositories
{
    public interface IActivityRepository
    {
        public List<ListActivityResponse> GetAllActivity();
        public void AddActivity(Activity activity);
    }
}
