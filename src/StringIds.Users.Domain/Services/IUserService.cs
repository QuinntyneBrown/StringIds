using StringIds.Users.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StringIds.Users.Domain.Services
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(string id);
        Task<User> InsertAsync(User user);
        Task InsertBatchAsync(IEnumerable<User> users);
    }
}
