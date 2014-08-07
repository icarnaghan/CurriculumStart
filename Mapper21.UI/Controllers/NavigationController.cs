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
        readonly string _currentYear = SiteConfig.CurrentYear;

        public NavigationController(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public ActionResult FirstSixWeeks()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetFirstSixWeeksByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "FirstSixWeeks", new { id = sectionId });
        }

        public ActionResult FallExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetFallExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "FallExpedition", new { id = sectionId });
        }

        public ActionResult MiniMester()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetMiniMesterByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "MiniMester", new { id = sectionId });
        }

        public ActionResult SpringExpedition()
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            sectionId = _sectionRepository.GetSpringExpeditionByGrade(gradeLevelId, _currentYear).Id;

            return RedirectToAction("Overview", "SpringExpedition", new { id = sectionId });
        }

        public ActionResult SubjectArea(string id)
        {
            var sectionId = 0;
            var gradeLevelId = CurrentGradeLevel();
            var subjectAreaId = CurrentSubjectArea(id);
            sectionId = _sectionRepository.GetSubjectAreaByGrade(gradeLevelId, _currentYear, subjectAreaId).Id;

            return RedirectToAction("Overview", "Strand", new { id = sectionId });
        }

        public int CurrentSubjectArea(string subjectArea)
        {
            var subjectAreaId = 0;
            if (subjectArea == "Art") subjectAreaId = 1;
            if (subjectArea == "ForeignLanguages") subjectAreaId = 2;
            if (subjectArea == "LanguageArts") subjectAreaId = 3;
            if (subjectArea == "Mathematics") subjectAreaId = 4;
            if (subjectArea == "Media") subjectAreaId = 5;
            if (subjectArea == "Music") subjectAreaId = 6;
            if (subjectArea == "PhysicalEducation") subjectAreaId = 7;
            if (subjectArea == "Science") subjectAreaId = 8;
            if (subjectArea == "SocialSkills") subjectAreaId = 9;
            if (subjectArea == "SocialStudies") subjectAreaId = 10;
            if (subjectArea == "Technology") subjectAreaId = 11;
            if (subjectArea == "Writing") subjectAreaId = 12;
            return subjectAreaId;
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