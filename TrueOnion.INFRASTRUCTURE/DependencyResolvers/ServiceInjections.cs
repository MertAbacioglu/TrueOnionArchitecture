using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.Settings;
using TrueOnion.INFRASTRUCTURE.Services;

namespace TrueOnion.INFRASTRUCTURE.DependencyResolvers
{
    public static class ServiceInjections
    {
        public static void AddInfrastructureLayerInjections(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IEMailService, EMailService>();
            services.Configure<MailSetting>(config.GetSection("MailSetting"));
        }
    }
}
