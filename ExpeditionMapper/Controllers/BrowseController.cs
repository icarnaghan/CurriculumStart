using System.Web.Mvc;

namespace ExpeditionMapper.Controllers
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