using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using Mapper21.UI.Config;

namespace Mapper21.UI.Controllers
{
    public class NavigationController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ICaseStudyRepository _caseStudyRepository;
        readonly string _currentYear = SiteConfig.CurrentYear;

        public NavigationController(ISectionRepository sectionRepository, ICaseStudyRepository caseStudyRepository)
        {
            _sectionRepository = sectionRepository;
            _caseStudyRepository = caseStudyRepository;
        }

        public ActionResult FirstSixWeeks()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetFirstSixWeeksByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Section", new { id = sectionId });
        }

        public ActionResult FallExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetFallExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Section", new { id = sectionId });
        }

        public ActionResult MiniMester()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetMiniMesterByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Section", new { id = sectionId });
        }

        public ActionResult SpringExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetSpringExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "Section", new { id = sectionId });
        }

        public int CurrentGradeLevel()
        {
            var gradeLevelId = 0;
            if (User.IsInRole("Kindergarten")) gradeLevelId = 1;
            if (User.IsInRole("First Grade")) gradeLevelId = 2;
            if (User.IsInRole("Second Grade")) gradeLevelId = 3;
            if (User.IsInRole("Third Grade")) gradeLevelId = 4;
            if (User.IsInRole("Fourth Grade")) gradeLevelId = 5;
            if (User.IsInRole("Fifth Grade")) gradeLevelId = 6;
            if (User.IsInRole("Sixth Grade")) gradeLevelId = 7;
            return gradeLevelId;
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