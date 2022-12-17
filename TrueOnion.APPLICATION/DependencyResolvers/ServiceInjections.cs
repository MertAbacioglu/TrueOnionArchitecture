using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using TrueOnion.APPLICATION.Mapping;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.Validators;

namespace TrueOnion.APPLICATION.DependencyResolvers
{
    public static class ServiceInjections
    {
        public static void AddApplicationLayer(this IServiceCollection service)
        {
            //service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddAutoMapper(typeof(MapProfile));

        }
    }
}
