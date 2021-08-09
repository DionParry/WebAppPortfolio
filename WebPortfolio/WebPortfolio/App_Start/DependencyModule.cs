using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using WebPortfolio.ApplicationServices;

namespace WebPortfolio
{
    public abstract class DependencyModule : DependencyResolver
    {
        public static void Load()
        {
            var builder = new ContainerBuilder();

            // MVC - Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            builder.RegisterType<HomeApplicationService>().AsImplementedInterfaces().PropertiesAutowired()
                .InstancePerRequest();
            
            // MVC - Set the dependency resolver to be Autofac.
            var container = builder.Build();
            SetResolver(new AutofacDependencyResolver(container));
        }
    }
}