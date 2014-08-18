using System;
using System.Web.Mvc;

namespace Mapper21.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            int year = Int32.Parse(CurrentYear);
            ViewBag.Grade = CurrentGradeLevel;
            ViewBag.Year = year  + " - " + (year + 1);
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