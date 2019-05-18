using Microsoft.EntityFrameworkCore;

namespace StringIds.Core.Models
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; }
    }
}
