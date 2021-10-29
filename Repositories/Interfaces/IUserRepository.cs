using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Services.DTOs;

namespace WebAPI.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>Gets the users asynchronous.</summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="fullName">The full name.</param>
        /// <returns>List of users</returns>
        Task<List<User>> GetUsersAsync(int? pageNumber, int? pageSize, string fullName);

        /// <summary>Gets the user by identifier asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Information of selected user</returns>
        Task<UserDetails> GetUserByIdAsync(int id);

        /// <summary>Deletes the user.</summary>
        /// <param name="id">The identifier.</param>
        Task DeleteUser(int id);
    }
}
