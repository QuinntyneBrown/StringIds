using Microsoft.EntityFrameworkCore;
using StringIds.Users.Domain.Models;
using StringIds.Core.Services;

namespace StringIds.Users.Domain.DataAccess
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<User> Users { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.UserId);

            modelBuilder.Entity<User>()
                .Property(x => x.UserId)
                .HasValueGenerator<GuidValueGenerator>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
