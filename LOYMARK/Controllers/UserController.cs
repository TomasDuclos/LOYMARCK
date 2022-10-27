using Microsoft.AspNetCore.Mvc;
using LOYMARK.Services;
using LOYMARK.Models;
using Microsoft.EntityFrameworkCore;

namespace LOYMARK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            this.userService = userService;
        }

        [HttpGet("get")]
        public User GetUser(int id)
        {
            try
            {
                return userService.GetUser(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("getall")]
        public List<User> GetAllUser()
        {
            try
            {
                return userService.GetAllUser();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("add")]
        public List<User> AddUser(User user)
        {
            try
            {
                return userService.AddUser(user);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("delete")]
        public List<User> DeleteUser(int id)
        {
            try
            {
                return userService.DeleteUser(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("update")]
        public List<User> UpdateUser(User user)
        {
            try
            {
                return userService.UpdateUser(user);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}