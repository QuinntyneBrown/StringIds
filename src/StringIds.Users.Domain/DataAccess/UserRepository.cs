using System.Collections.Generic;
using System.Threading.Tasks;
using StringIds.Users.Domain.Models;

namespace StringIds.Users.Domain.DataAccess
{
    public class UserRepository: IUserRepository
    {
        private readonly IAppDbContext _context;
        public UserRepository(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> InsertAsync(User user)
        {
            return (await _context.Users.AddAsync(user)).Entity;
        }

        public async Task InsertBatchAsync(IEnumerable<User> users)
        {
            await _context.Users.AddRangeAsync(users);
        }
    }
}
