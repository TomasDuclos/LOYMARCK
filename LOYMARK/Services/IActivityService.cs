using LOYMARK.Models;

namespace LOYMARK.Services
{
    public interface IActivityService
    {
        public List<ListActivityResponse> GetAllActivity();
        public void AddActivity(Activity activity);
    }
}
