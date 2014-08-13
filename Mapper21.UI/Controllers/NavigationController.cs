using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Interfaces;
using Mapper21.UI;
using Mapper21.UI.Helpers;
using Microsoft.AspNet.Identity.EntityFramework;
using Mapper21.UI.Config;

namespace Mapper21.UI.Controllers
{
    public class NavigationController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        readonly string _currentYear = SiteConfig.CurrentYear;

        public NavigationController(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public ActionResult FirstSixWeeks()
        {
            var sectionId = 0;
            var gradeLevelId = PermissionHelpers.GetCurrentGradeLevel(User);
            sectionId = _sectionRepository.GetFirstSixWeeksByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "FirstSixWeeks", new { id = sectionId });
        }

        public ActionResult FallExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = "2";
            //var gradeLevelId = PermissionHelpers.GetCurrentGradeLevel(User);
            sectionId = _sectionRepository.GetFallExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Expedition", new { id = sectionId });
        }

        public ActionResult MiniMester()
        {
            var sectionId = 0;
            var gradeLevelId = PermissionHelpers.GetCurrentGradeLevel(User);
            sectionId = _sectionRepository.GetMiniMesterByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Expedition", new { id = sectionId });
        }

        public ActionResult SpringExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = PermissionHelpers.GetCurrentGradeLevel(User);
            sectionId = _sectionRepository.GetSpringExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Expedition", new { id = sectionId });
        }

        public ActionResult SubjectArea(string id)
        {
            var sectionId = 0;
            var gradeLevelId = PermissionHelpers.GetCurrentGradeLevel(User);
            var subjectAreaId = PermissionHelpers.CurrentSubjectArea(id);
            sectionId = _sectionRepository.GetSubjectAreaByGrade(gradeLevelId, _currentYear, subjectAreaId).Id;

            return RedirectToAction("Overview", "Strand", new { id = sectionId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _sectionRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}