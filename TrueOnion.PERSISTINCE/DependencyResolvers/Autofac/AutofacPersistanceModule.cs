using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.PERSISTINCE.Context;
using TrueOnion.PERSISTINCE.Repositories;
using TrueOnion.PERSISTINCE.Services;
using Module = Autofac.Module;
namespace TrueOnion.PERSISTINCE.DependencyResolvers.Autofac
{
    public class AutofacPersistanceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericService<,,>))
                .As(typeof(IGenericService<,,>)).InstancePerLifetimeScope();


            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Assembly repoServiceAssembly = Assembly.GetAssembly(typeof(AppDbContext));


            builder.RegisterAssemblyTypes(executingAssembly, repoServiceAssembly)
                .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces()
                .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(executingAssembly, repoServiceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.Register(c =>
            {
                IConfiguration config = c.Resolve<IConfiguration>();

                DbContextOptionsBuilder<AppDbContext> opt = new DbContextOptionsBuilder<AppDbContext>();
                opt.UseSqlServer(config.GetSection("ConnectionStrings:SqlConnection").Value);
                return new AppDbContext(opt.Options);
            }).AsSelf().InstancePerLifetimeScope();


        }
    }
}
