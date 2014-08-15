using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;

namespace Mapper21.UI.Controllers
{
    public class SectionController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ILookupRepository _lookupRepository;

        public SectionController(ISectionRepository sectionRepository, 
                                 ILookupRepository lookupRepository)
        {
            _sectionRepository = sectionRepository;
            _lookupRepository = lookupRepository;
        }

        // GET: /Expedition/SubSection/SectionType
        public ActionResult SubSection(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Expedition/FinalProduct/SectionType
        public ActionResult FinalProduct(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /Expedition/FinalProduct/SectionType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinalProduct(Section section)
        {
            if (ModelState.IsValid)
            {
                _sectionRepository.InsertorUpdate(section);
                _sectionRepository.Save();

                return RedirectToAction("Index", "Home");
            }
            return View(section);
        }

        // GET: /Expedition/Overview/SectionType
        public ActionResult Overview(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            return View(section);
        }

        // POST: /Expedition/Overview/SectionType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(Section section)
        {
            if (ModelState.IsValid)
            {
                _sectionRepository.InsertorUpdate(section);
                _sectionRepository.Save();
            }
            return View(section);
        }

        // GET: /Expedition/GuidingQuestions/SectionType
        public ActionResult GuidingQuestions(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Expedition/Habits/SectionType
        public ActionResult Habits(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var habit = _lookupRepository.GetHabits();
            ViewData["HabitList"] = new SelectList(habit, "Id", "Name");

            return View(section);
        }

        // GET: /Expedition/ScienceBigIdeas/SectionType
        public ActionResult ScienceBigIdeas(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForScience = _lookupRepository.GetBigIdeaForSciences();
            ViewData["BigIdeaForScienceList"] = new SelectList(bigIdeaForScience, "Id", "Name");

            return View(section);
        }

        // GET: /Expedition/SocialStudiesBigIdeas/SectionType
        public ActionResult SocialStudiesBigIdeas(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, id);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForSocialStudies = _lookupRepository.GetBigIdeaForSocialStudies();
            ViewData["BigIdeaForSocialStudiesList"] = new SelectList(bigIdeaForSocialStudies, "Id", "Name");

            return View(section);
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