using Microsoft.Extensions.DependencyInjection;
using TrueOnion.APPLICATION.Mapping;

namespace TrueOnion.APPLICATION.DependencyResolvers
{
    public static class ServiceInjection
    {
        public static void AddApplicationLayerInjections(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
        }
    }
}
