using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories.Interfaces;
using WebAPI.Services.DTOs;

namespace WebAPI.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public async Task<List<User>> GetUsersAsync(int? pageNumber, int? pageSize, string fullName)
        {
            return await GetAll()
                .Where(q => q.isActive == true)
                .Where(q => (fullName != null ? (q.Name + " " + q.Surname).StartsWith(fullName) : true))

                .Skip(((int)pageNumber - 1) * (int)pageSize)
                .Take((int)pageSize)

                .Select(s => new User
                {
                    Id = s.Id,
                    Name = s.Name,
                    Surname = s.Surname
                })
                .ToListAsync();
        }

        public async Task<UserDetails> GetUserByIdAsync(int id)
        {
            var entity = await GetAll()
                .Where(q => q.Id == id)
                .Select(s => new UserDetails
                {
                    Id = s.Id,
                    Name = s.Name,
                    Surname = s.Surname,
                    BirthDate = s.BirthDate,
                    UserTypeId = s.UserTypeId,
                    UserType = s.UserType.Description,
                    UserTitleId = s.UserTitleId,
                    UserTitle = s.UserTitle.Description,
                    EmailAddress = s.EmailAddress,
                    isActive = s.isActive
                }).FirstOrDefaultAsync();

            return entity;
        }

        public async Task DeleteUser(int id)
        {
            var entity = await GetByIdAsync(id);

            entity.isActive = false;
            await UpdateAsync(entity);
        }
    }
}
