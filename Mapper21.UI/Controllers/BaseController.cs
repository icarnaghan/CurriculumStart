using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.UI.Config;
using Mapper21.UI.Helpers;

namespace Mapper21.UI.Controllers
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