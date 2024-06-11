using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DAPM_Full
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DAPM_Full.Controllers" }
            );
            routes.MapRoute(
            name: "RestaurantOwner",
            url: "RestaurantOwner/{controller}/{action}/{id}",
            defaults: new { action = "Index", id = UrlParameter.Optional },
            namespaces: new[] { "DAPM_Full.Areas.RestaurantOwner.Controllers" }
        ).DataTokens["area"] = "RestaurantOwner";

            routes.MapRoute(
            name: "Admin",
            url: "Admin/{controller}/{action}/{id}",
            defaults: new { action = "Index", id = UrlParameter.Optional }
        ).DataTokens["area"] = "Admin";
        }
    }
}
