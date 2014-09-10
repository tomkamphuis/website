using System.Web.Mvc;
using System.Web.Routing;

namespace TomKamphuisOnSpaAndAngular
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Profile",
                url: "Profile",
                defaults: new { controller = "Portfolio", action = "Profile" }
            );

            routes.MapRoute(
                name: "Resume",
                url: "Resume",
                defaults: new { controller = "Portfolio", action = "Resume" }
            );

            routes.MapRoute(
                name: "Portfolio",
                url: "Portfolio",
                defaults: new { controller = "Portfolio", action = "Portfolio" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { controller = "Portfolio", action = "Contact" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Portfolio", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}