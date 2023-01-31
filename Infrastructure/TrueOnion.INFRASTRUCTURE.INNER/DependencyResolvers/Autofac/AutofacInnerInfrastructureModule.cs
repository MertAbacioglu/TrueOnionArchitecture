using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.PERSISTINCE.Context;
using Module = Autofac.Module;

namespace TrueOnion.INFRASTRUCTURE.INNER.DependencyResolvers.Autofac
{
    public class AutofacInnerInfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterGeneric(typeof(GenericService<,,>))
                .As(typeof(IGenericService<,,>)).InstancePerLifetimeScope();


            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Assembly repoServiceAssembly = Assembly.GetAssembly(typeof(AppDbContext));



            builder.RegisterAssemblyTypes(executingAssembly, repoServiceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();




        }
    }
}
