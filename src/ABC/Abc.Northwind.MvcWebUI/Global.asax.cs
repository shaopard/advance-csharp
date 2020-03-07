using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Abc.Core.Utilities.MVC.Infrastructure.Ninject;
using Abc.Northwind.Business.DependencyResolvers.Ninject;

namespace Abc.Northwind.MvcWebUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessIoCModule()));
        }
    }
}