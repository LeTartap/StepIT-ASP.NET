using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("David","david/{noflines}",
                defaults: new { controller = "MyDemo", action = "david", noflines = UrlParameter.Optional }
            );

            routes.MapRoute("test", "test/{id}",
             defaults: new { controller = "MyDemo", action = "Article" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
