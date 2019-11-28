using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cuisine",
                url: "cuisine/{name}",
                defaults: new {controller = "Cuisine", action="Search", name = UrlParameter.Optional }

            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Paimla",
                url: "paimla/{action}/{country}{action2}/{Food}",
                defaults: new { controller = "Paimla", action = "Index", Country = UrlParameter.Optional, Food = UrlParameter.Optional },
                constraints: new { id = @"\d+"}
            );
        }
    }
}
