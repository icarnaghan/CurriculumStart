using System.Web.Mvc;
using System.Web.Routing;

namespace Mapper21.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute( "SectionOverview", "Section/Overview/{sectionType}",
                new { controller = "Section", action = "Overview", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionHabits", "Section/Habits/{sectionType}",
                new { controller = "Section", action = "Habits", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionGuidingQuestions", "Section/GuidingQuestions/{sectionType}",
                new { controller = "Section", action = "GuidingQuestions", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionScienceBigIdeas", "Section/ScienceBigIdeas/{sectionType}",
                new { controller = "Section", action = "ScienceBigIdeas", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionSocialStudiesBigIdeas", "Section/SocialStudiesBigIdeas/{sectionType}",
                new { controller = "Section", action = "SocialStudiesBigIdeas", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionFinalProduct", "Section/FinalProduct/{sectionType}",
                new { controller = "Section", action = "FinalProduct", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionSubSection", "Section/SubSection/{sectionType}",
                new { controller = "Section", action = "SubSection", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("CreateSubSection", "Section/CreateSubSection/{sectionType}",
                new { controller = "Section", action = "CreateSubSection", sectionType = UrlParameter.Optional }
            );

            routes.MapRoute("EditSubSection", "Section/EditSubSection/{sectionType}/{id}",
                new { controller = "Section", action = "EditSubSection", sectionType = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}