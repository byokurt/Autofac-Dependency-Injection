using Autofac;
using Autofac.Integration.WebApi;
using AutoFackExample.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace AutoFackExample.Helpers
{
    public static class AutofacDependecyBuilder
    {
        public static void DependencyBuilder()
        {
            // Create the builder with which components/services are registered.
            var builder = new ContainerBuilder();

            builder.RegisterType<DataContext>().As<DbContext>().InstancePerRequest();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(t => t.GetCustomAttribute<InjectableAttribute>() != null).AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Build the Container
            var container = builder.Build();

            //Create the Dependency Resolver
            var resolver = new AutofacWebApiDependencyResolver(container);

            //COnfiguring WebApi with Dependency Resolver
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}