using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mapper21.UI.Controllers
{
    public class SupportController : BaseController
    {
        //
        // GET: /Support/
        public ActionResult Index()
        {
            if(Session != null && Session["GradeLevel"] == null)
            {
                Session["GradeLevel"] = "K";
            }
            return View();
        }

        public ActionResult GetGrade(string gradeLevel)
        {
            Session["GradeLevel"] = gradeLevel; 
            return RedirectToAction("Overview", "Section", new { currentSectionType = "Overview" });
        }
	}
}