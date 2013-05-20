using System;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Routing;
using MvcContrib.ControllerFactories;
using MvcContrib.Services;
using MvcContrib.Spring;
using Spring.Core.IO;
using Spring.Objects.Factory;
using Spring.Objects.Factory.Xml;

namespace CSoftZ.Demo.Web {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
            ConfigureIoC();
        }

        private void ConfigureIoC() {
            IResource input = new FileSystemResource(Server.MapPath("objects.xml"));
            IObjectFactory factory = new XmlObjectFactory(input);
            DependencyResolver.InitializeWith(new SpringDependencyResolver(factory));

            ControllerBuilder.Current.SetControllerFactory(typeof(IoCControllerFactory));
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e) {
            //Create culture info object 
            CultureInfo ci = new CultureInfo("es");

            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);
        }
    }
}