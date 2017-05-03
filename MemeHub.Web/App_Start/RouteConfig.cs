using System.Web.Mvc;
using System.Web.Routing;

namespace MemeHub.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            AreaRegistration.RegisterAllAreas();
            routes.MapRoute(
           "Phefault",
           "{controller}/{action}/{id}",
            new { controller = "Home", action = "All", id = UrlParameter.Optional }
            );
        }
    }
}
