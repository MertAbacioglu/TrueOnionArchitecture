using Microsoft.Extensions.DependencyInjection;
using TrueOnion.APPLICATION.Mapping;

namespace TrueOnion.APPLICATION.DependencyResolvers
{
    public static class ServiceInjections
    {
        public static void AddApplicationLayerInjections(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
        }
    }
}
