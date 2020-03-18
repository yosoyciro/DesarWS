using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NHibernate;
using DAL.Sesion;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static ISessionFactory SessionFactory
        {
            get;
            private set;
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Inicio la sesion por unica vez
            SessionFactory = GenerarSesion.Instancia.SessionFactory();

            //Fuera JSON, solo XML
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
        }
    }
}
