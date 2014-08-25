using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mapper21.UI.Controllers
{
    public class SupportController : BaseController
    {
        public ActionResult GetGrade(string gradeLevel)
        {
            Session["GradeLevel"] = gradeLevel;
            var grade = Session["GradeLevel"].ToString();
            return RedirectToAction("Index", "Home");
        }
	}
}