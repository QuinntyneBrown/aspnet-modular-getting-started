using System.Web.Mvc;
using System.Web.Routing;
using Chloe.Metal.Extensions;

namespace Chloe.App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Map(
                name: "Player",
                url: "player/{playerName}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.Map(
                name: "Players",
                url: "players",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.Map(
                name: "Default",
                url: "{*catch-all}",
                defaults: new { controller = "Default", action ="Index" }
            );           
        }
    }
}