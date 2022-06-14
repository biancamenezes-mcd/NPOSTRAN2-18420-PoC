using Library.Models;
using Microsoft.Extensions.Configuration;
using Library.Models.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library.Configuration
{
    public static class DependencyInjection
    {
        public static void AddLibraryDependencies(this IServiceCollection services)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            services.AddSingleton<StldProducer>();

            DomainSettings settings = config
                .GetRequiredSection("LibSettings")
                .GetRequiredSection("DomainSettings")
                .Get<DomainSettings>();

            services.AddSingleton(settings);
        }
    }
}
