using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StringIds.Core.Services;
using StringIds.Users.Domain.Configuration;
using StringIds.Users.Domain.DataAccess;
using StringIds.Users.Domain.Models;
using StringIds.Users.Domain.Services;

namespace StringIds.Users.Api
{
    public static class Dependencies
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration config)
        {
            // NOTE: Use singletons whenever possible to decrease memory utilization

            // Configuration
            services.Configure<ConnectionStringsOptions>(config.GetSection("ConnectionStrings"));
            services.Configure<UserServiceOptions>(config.GetSection("UserService"));

            // Data Access
            services.AddDbContext<AppDbContext>(options =>
            {
                options
                .UseSqlServer(config["ConnectionStrings:UsersDatabase"], b => b.MigrationsAssembly("StringsIds.Users.Domain"));
            });

            services.AddSingleton<IUserRepository, UserRepository>();

            // Services 
            services.AddSingleton<IMachineTimeService, MachineTimeService>();
            services.AddUserService(config);
        }

        private static void AddUserService(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IUserService>(r =>
            {
                var svc = new UserService(
                    r.GetRequiredService<IUserRepository>()
                );
                return svc;
            });
        }
    }
}
