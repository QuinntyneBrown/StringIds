using System.Collections.Generic;
using System.Threading.Tasks;

namespace StringIds.Users.Domain.Models
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(string id);
        Task<User> InsertAsync(User user);
        Task InsertBatchAsync(IEnumerable<User> users);
    }
}
