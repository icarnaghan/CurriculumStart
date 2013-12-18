using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ExpeditionMapper.UI.App_Start;

namespace ExpeditionMapper.UI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}