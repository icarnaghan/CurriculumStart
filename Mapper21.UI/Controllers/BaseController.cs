using System.Web.Mvc;
using Mapper21.BE.Domain;

namespace Mapper21.UI.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public int CurrentSectionTypeId;
        public int CurrentGradeLevelId;
    }
}