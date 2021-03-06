using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartCentral.Data;
using SmartCentral.HealthChecks;

namespace SmartCentral.Installers
{
    public class HealthChecksInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<DataContext>()
                .AddCheck<RedisHealthCheck>("Redis");
        }
    }
}