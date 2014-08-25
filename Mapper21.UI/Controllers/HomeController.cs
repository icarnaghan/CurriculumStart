using System;
using System.Web.Mvc;
using Mapper21.UI.Helpers;

namespace Mapper21.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var year = Int32.Parse(CurrentYear);
            if (Session != null) ViewBag.Grade = CurrentGradeLevel == "" ? Session["GradeLevel"] : CurrentGradeLevel;
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