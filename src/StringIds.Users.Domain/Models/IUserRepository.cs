using System.Collections.Generic;
using System.Threading.Tasks;

namespace StringIds.Users.Domain.Models
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(string id);
        Task<bool> InsertAsync(User user);
        Task<int> InsertBatchAsync(IEnumerable<User> users);
    }
}
