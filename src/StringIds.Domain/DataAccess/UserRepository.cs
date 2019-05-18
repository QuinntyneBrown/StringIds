using StringIds.Core.Models;

namespace StringIds.Domain.DataAccess
{
    public class UserRepository: IUserRepository
    {
        private readonly IAppDbContext _context;
        public UserRepository(IAppDbContext context)
        {
            _context = context;
        }
    }
}
