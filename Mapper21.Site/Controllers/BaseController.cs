using System.Web.Mvc;
using Mapper21.Site.Config;
using Mapper21.Site.Helpers;

namespace Mapper21.Site.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public int CurrentSectionTypeId;
        public string CurrentGradeLevel
        {
            get { return PermissionHelpers.GetCurrentGradeLevel(User); }
        }

        public string CurrentYear
        {
            get { return SiteConfig.CurrentYear; }
        }
    }
}