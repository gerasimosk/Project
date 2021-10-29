﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Services.DTOs;

namespace WebAPI.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>Gets the users asynchronous.</summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="fullName">The full name.</param>
        /// <returns>List of users</returns>
        Task<ActionResult<List<User>>> getUsersAsync(int? pageNumber, int? pageSize, string fullName);
        
        /// <summary>Gets the user by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>All the information about the user</returns>
        Task<UserDetails> GetUSerById(int id);
        
        /// <summary>Adds the user asynchronous.</summary>
        /// <param name="user">The user.</param>
        /// <returns>The added user.</returns>
        Task<User> AddUserAsync(User user);
        
        /// <summary>Updates the user asynchronous.</summary>
        /// <param name="user">The user.</param>
        /// <returns>The updated user.</returns>
        Task<User> UpdateUserAsync(User user);
        
        /// <summary>Deletes the user asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        Task DeleteUserAsync(int id);
    }
}
