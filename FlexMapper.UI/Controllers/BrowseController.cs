using System.Web.Mvc;

namespace FlexMapper.UI.Controllers
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