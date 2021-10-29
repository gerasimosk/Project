using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Services.DTOs;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>Gets all users.</summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="fullName">The full name.</param>
        /// <returns>List of users.</returns>
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers(int? pageNumber, int? pageSize, string fullName)
        {
            return await _userService.getUsersAsync(pageNumber, pageSize, fullName);
        }

        /// <summary>Gets the user by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Details of user.</returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<UserDetails> GetUserById(int id)
        {
            return await _userService.GetUSerById(id);
        }

        /// <summary>Add a user.</summary>
        /// <param name="user">The user.</param>
        [HttpPost]
        public async Task Add([FromBody] User user)
        {
            await _userService.AddUserAsync(user);
        }

        /// <summary>Updates the specified user.</summary>
        /// <param name="user">The user.</param>
        [HttpPut]
        public async Task Update([FromBody] User user)
        {
            await _userService.UpdateUserAsync(user);
        }

        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteUserAsync(id);
        }
    }
}
