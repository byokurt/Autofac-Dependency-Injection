using Autofac;
using Autofac.Integration.WebApi;
using AutoFackExample.Business.Abstractions;
using AutoFackExample.Business.Implementations;
using AutoFackExample.Data;
using AutoFackExample.Data.Repository.Abstractions;
using AutoFackExample.Data.Repository.Implementations;
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
            var builder = new ContainerBuilder();

            builder.RegisterType<DataContext>().As<DbContext>().InstancePerRequest();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(t => t.GetCustomAttribute<InjectableAttribute>() != null).AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}