using System.Web.Mvc;

namespace ExpeditionMapper.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unavailable()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Support()
        {
            return View();
        }
    }
}