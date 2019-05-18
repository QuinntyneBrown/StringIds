using System.Collections.Generic;
using System.Threading.Tasks;
using StringIds.Users.Domain.Models;

namespace StringIds.Users.Domain.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(
            IUserRepository repo)
        {
            _repo = repo;
        }

        public Task<User> GetByIdAsync(string id)
        {
            var result = _repo.GetByIdAsync(id);
            return result;
        }

        public async Task<User> InsertAsync(User user)
        {
            return null;
        }

        public async Task<int> InsertBatchAsync(IEnumerable<User> users)
        {
            throw new System.NotImplementedException();
        }
    }
}
