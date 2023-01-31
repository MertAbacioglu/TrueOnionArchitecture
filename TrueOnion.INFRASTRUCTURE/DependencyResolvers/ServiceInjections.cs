using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.Settings;
using TrueOnion.INFRASTRUCTURE.OUTER.Services;

namespace TrueOnion.INFRASTRUCTURE.OUTER.Services
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
