using Microsoft.EntityFrameworkCore;

namespace StringIds.Users.Domain.Models
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; }
    }
}
