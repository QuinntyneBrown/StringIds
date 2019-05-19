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

        public Task<User> GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> InsertBatchAsync(IEnumerable<User> users)
        {
            throw new System.NotImplementedException();
        }
    }
}
