using System.Web.Mvc;
using System.Web.Routing;

namespace Mapper21.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SupportGetGrade", "Support/GetGrade/{gradeLevel}",
                new { controller = "Support", action = "GetGrade", gradeLevel = UrlParameter.Optional }
            );
            
            routes.MapRoute("StaEdit", "Sta/Edit/{currentSectionType}/{subSectionId}/{id}",
                new { controller = "Sta", action = "Edit", currentSectionType = UrlParameter.Optional, subSectionId = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute("StaCreate", "Sta/Create/{currentSectionType}/{subSectionId}",
                new { controller = "Sta", action = "Create", currentSectionType = UrlParameter.Optional, subSectionId = UrlParameter.Optional }
            );

            routes.MapRoute("SectionOverview", "Section/Overview/{currentSectionType}",
                new { controller = "Section", action = "Overview", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionHabits", "Section/Habits/{currentSectionType}",
                new { controller = "Section", action = "Habits", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionGuidingQuestions", "Section/GuidingQuestions/{currentSectionType}",
                new { controller = "Section", action = "GuidingQuestions", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionScienceBigIdeas", "Section/ScienceBigIdeas/{currentSectionType}",
                new { controller = "Section", action = "ScienceBigIdeas", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionSocialStudiesBigIdeas", "Section/SocialStudiesBigIdeas/{currentSectionType}",
                new { controller = "Section", action = "SocialStudiesBigIdeas", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionOtherBigIdeas", "Section/OtherBigIdeas/{currentSectionType}",
                new { controller = "Section", action = "OtherBigIdeas", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionFinalProduct", "Section/FinalProduct/{currentSectionType}",
                new { controller = "Section", action = "FinalProduct", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("SectionSubSection", "Section/SubSection/{currentSectionType}",
                new { controller = "Section", action = "SubSection", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("CreateSubSection", "Section/CreateSubSection/{currentSectionType}",
                new { controller = "Section", action = "CreateSubSection", currentSectionType = UrlParameter.Optional }
            );

            routes.MapRoute("EditSubSection", "Section/EditSubSection/{currentSectionType}/{id}",
                new { controller = "Section", action = "EditSubSection", currentSectionType = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}