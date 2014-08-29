using System.Web.Mvc;

namespace Mapper21.Site.Controllers
{
    public class BrowseController : BaseController
    {
        //
        // GET: /Browse/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Results()
        {
            return View();
        }
    }
}