using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Mapper21.UI.Models;

namespace Mapper21.UI.Controllers
{
    public class SectionController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ISubSectionRepository _subSectionRepository;
        private readonly ILookupRepository _lookupRepository;

        public SectionController(ISectionRepository sectionRepository,
                                 ISubSectionRepository subSectionRepository,
                                 ILookupRepository lookupRepository)
        {
            _sectionRepository = sectionRepository;
            _subSectionRepository = subSectionRepository;
            _lookupRepository = lookupRepository;
        }

        // GET: /Section/SubSection/SectionType
        public ActionResult SubSection(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/CreateSubSection
        public ActionResult CreateSubSection(string currentSectionType)
        {
            var newSubSection = new SubSection()
            {
                SectionId = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType).Id,
                SubSectionTypeId = Helpers.PermissionHelpers.GetSubSectionType(currentSectionType),
            };

            return View(newSubSection);
        }

        // POST: /Section/CreateSubSection
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSubSection(SubSection subSection)
        {
            if (ModelState.IsValid)
            {
                _subSectionRepository.InsertorUpdate(subSection);
                _subSectionRepository.Save();
                return RedirectToAction("EditSubSection", "Section", new { subSection.Id });
            }

            return View(subSection);
        }

        // GET: /Section/EditSubSection/5
        public ActionResult EditSubSection(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var subSection = _subSectionRepository.Find(id);
            
            // Get SelectLists
            List<SubSectionStaGrid> staGrid = _subSectionRepository.GetStaGrids(id).ToList();
            ViewBag.staGrid = staGrid;

            var habit = _lookupRepository.GetHabits();
            ViewData["HabitList"] = new SelectList(habit, "Id", "Name");


            return View(subSection);
        }

        // POST: /Section/EditSubSection/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSubSection(SubSection subSection)
        {
            if (ModelState.IsValid)
            {
                subSection.Description = HttpUtility.HtmlDecode(subSection.Description);
                _subSectionRepository.InsertorUpdate(subSection);
                _subSectionRepository.Save();
                return RedirectToAction("EditSubSection", "Section", new { id = subSection.Id });
            }
            return View(subSection);
        }

        // GET: /Section/FinalProduct/SectionType
        public ActionResult FinalProduct(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /Section/FinalProduct/SectionType
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

        // GET: /Section/Overview/SectionType
        public ActionResult Overview(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            return View(section);
        }

        // POST: /Section/Overview/SectionType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(Section section)
        {
            if (ModelState.IsValid)
            {
                section.Description = HttpUtility.HtmlDecode(section.Description);
                _sectionRepository.InsertorUpdate(section);
                _sectionRepository.Save();
            }
            return View(section);
        }

        // GET: /Section/GuidingQuestions/SectionType
        public ActionResult GuidingQuestions(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/Habits/SectionType
        public ActionResult Habits(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var habit = _lookupRepository.GetHabits();
            ViewData["HabitList"] = new SelectList(habit, "Id", "Name");

            return View(section);
        }

        // GET: /Section/ScienceBigIdeas/SectionType
        public ActionResult ScienceBigIdeas(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForScience = _lookupRepository.GetBigIdeaForSciences();
            ViewData["BigIdeaForScienceList"] = new SelectList(bigIdeaForScience, "Id", "Name");

            return View(section);
        }

        // GET: /Section/SocialStudiesBigIdeas/SectionType
        public ActionResult SocialStudiesBigIdeas(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForSocialStudies = _lookupRepository.GetBigIdeaForSocialStudies();
            ViewData["BigIdeaForSocialStudiesList"] = new SelectList(bigIdeaForSocialStudies, "Id", "Name");

            return View(section);
        }

        // GET: /Section/OtherBigIdeas/SectionType
        public ActionResult OtherBigIdeas(string currentSectionType)
        {
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.GetSection(CurrentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
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