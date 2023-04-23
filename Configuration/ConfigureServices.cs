using AltanDenemeC.Data;
using AltanDenemeC.Models;
using AltanDenemeC.Repository;
using AltanDenemeC.Services;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AltanDenemeC.Configuration
{
    public class AutofacConfig
    {
        public static IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<UserService>().InstancePerLifetimeScope();
            builder.RegisterType<EfRepository<Users>>().InstancePerLifetimeScope();
            builder.RegisterType<DatabaseContext>().AsSelf().InstancePerLifetimeScope();           
            
            //builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            //builder.RegisterType<EfRepository<Users>>().As<IEfRepository<Users>>().InstancePerLifetimeScope();
            //builder.RegisterType<DatabaseContext>().AsSelf().InstancePerLifetimeScope();
            var container = builder.Build();
            return new AutofacServiceProvider(container);

            

        }
    }
}
