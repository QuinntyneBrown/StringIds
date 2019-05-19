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
            return await _repo.InsertAsync(user);
        }

        public async Task InsertBatchAsync(IEnumerable<User> users)
        {
            await _repo.InsertBatchAsync(users);
        }
    }
}
