using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DAPM_Full
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           
        }
    }

    // Implementation of IAppBuilder for demonstration purposes
    public class AppBuilder : IAppBuilder
    {
        public IAppBuilder Use(object middleware, params object[] args)
        {
            return this;
        }

        public object Build(Type returnType)
        {
            return null;
        }

        public IAppBuilder New()
        {
            return new AppBuilder();
        }

        public IDictionary<string, object> Properties { get; } = new Dictionary<string, object>();
    }
}
