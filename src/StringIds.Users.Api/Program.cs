using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StringIds.Users.Api
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var envVarConfig = (EnvironmentVariablesConfigurationSource)config.Sources
                        .FirstOrDefault(x => x.GetType() == typeof(EnvironmentVariablesConfigurationSource));

                    if (envVarConfig != null)
                        envVarConfig.Prefix = "STRINGIDS-USER-";

                })
                .UseStartup<Startup>();

            return builder;
        }
    }
}
