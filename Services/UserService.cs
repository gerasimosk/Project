using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain;
using WebAPI.Repositories.Interfaces;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new System.ArgumentNullException(nameof(userRepository));
        }

        public async Task<ActionResult<List<User>>> GetUsersAsync(int? pageNumber, int? pageSize, string fullName)
        {
            return await _userRepository.GetUsersAsync(pageNumber, pageSize, fullName);
        }

        public async Task<User> GetUSerById(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUser(id);
        }
    }
}
