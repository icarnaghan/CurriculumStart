using System.Web.Mvc;

namespace Mapper21.Site.Controllers
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