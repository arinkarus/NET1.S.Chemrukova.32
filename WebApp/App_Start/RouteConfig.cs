using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApp.Infrastructure;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // For task 1
            //routes.IgnoreRoute("Image/{*path}");

            // For task 2
            //Route imageRoute = new Route("Image/{id}", new ImageRouteHandler());
            //routes.Add(imageRoute);

            routes.MapRoute(
                name: "ImageRoute",
                url: "{controller}/{id}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
