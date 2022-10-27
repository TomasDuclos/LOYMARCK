using LOYMARK.Models;
using LOYMARK.Services;
using Microsoft.AspNetCore.Mvc;

namespace LOYMARK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly ILogger<ActivityController> _logger;

        public ActivityController(ILogger<ActivityController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getall")]
        public List<ListActivityResponse> GetAllUser()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}