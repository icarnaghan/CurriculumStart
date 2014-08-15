using System.Web.Mvc;
using System.Web.Routing;

namespace Mapper21.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "CreateSubSection",
                "Section/CreateSubSection/{sectionType}",
                new
                {
                    controller = "Section",
                    action = "CreateSubSection",
                    sectionType = UrlParameter.Optional,
                }
             );

             routes.MapRoute(
                "EditSubSection",
                "Section/EditSubSection/{sectionType}/{id}",
                new
                {
                    controller = "Section",
                    action = "EditSubSection",
                    sectionType = UrlParameter.Optional,
                    id = UrlParameter.Optional
                }
             );


            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            //routes.MapRoute("SubSection", "{controller}/{action}/{SectionType}/{id}",
            //    new { controller = "Section", action = "EditSubSection", SectionType = UrlParameter.Optional, id = UrlParameter.Optional }
            //    );


        }
    }
}