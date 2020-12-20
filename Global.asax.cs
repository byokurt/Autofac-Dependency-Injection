using AutoFackExample.Helpers;
using System.Web.Http;

namespace AutoFackExample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacDependecyBuilder.DependencyBuilder();
        }
    }
}
