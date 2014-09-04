using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mapper21.Business.Dto;
using Mapper21.Business.Interfaces;
using Mapper21.Data.Interfaces;
using Mapper21.Domain;
using Mapper21.Site.Helpers;

namespace Mapper21.Site.Controllers
{
    public class SectionController : BaseController
    {
        private readonly ISubSectionRepository _subSectionRepository;
        private readonly ILookupManager _lookupManager;
        private readonly ISectionManager _sectionManager;

        public SectionController(ISubSectionRepository subSectionRepository,
                                 ILookupManager lookupManager,
                                 ISectionManager sectionManager)
        {
            _subSectionRepository = subSectionRepository;
            _lookupManager = lookupManager;
            _sectionManager = sectionManager;
        }

        // GET: /Section/SubSection/SectionType
        public ActionResult SubSection(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/CreateSubSection
        public ActionResult CreateSubSection(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            var newSubSection = new SubSection
            {
                SectionId = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType).Id,
                SubSectionTypeId = PermissionHelpers.GetSubSectionType(currentSectionType),
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
        public ActionResult EditSubSection(Guid id)
        {
            var subSection = _subSectionRepository.Find(id);
            
            // Get SelectLists
            List<SubSectionStaGrid> staGrid = _subSectionRepository.GetStaGrids(id).ToList();
            ViewBag.staGrid = staGrid;

            var habit = _lookupManager.GetHabits();
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
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /Section/FinalProduct/SectionType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinalProduct(SectionDto section)
        {
            if (ModelState.IsValid)
            {
                _sectionManager.SaveOrUpdate(section);
                
                TempData["SuccessMessage"] = "Final Product has been updated";
                return RedirectToAction("FinalProduct", "Section");
            }
            return View(section);
        }

        // GET: /Section/Overview/SectionType
        public ActionResult Overview(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            return View(section);
        }

        // POST: /Section/Overview/SectionType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(SectionDto section)
        {
            if (ModelState.IsValid)
            {
                section.Description = HttpUtility.HtmlDecode(section.Description);
                _sectionManager.SaveOrUpdate(section);

                TempData["SuccessMessage"] = "Overview has been updated";
                return RedirectToAction("Overview", "Section");
            }
            return View(section);
        }

        // GET: /Section/GuidingQuestions/SectionType
        public ActionResult GuidingQuestions(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/Habits/SectionType
        public ActionResult Habits(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var habit = _lookupManager.GetHabits();
            ViewData["HabitList"] = new SelectList(habit, "Id", "Name");

            return View(section);
        }

        // GET: /Section/ScienceBigIdeas/SectionType
        public ActionResult ScienceBigIdeas(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForScience = _lookupManager.GetBigIdeaForSciences();
            ViewData["BigIdeaForScienceList"] = new SelectList(bigIdeaForScience, "Id", "Name");

            return View(section);
        }

        // GET: /Section/SocialStudiesBigIdeas/SectionType
        public ActionResult SocialStudiesBigIdeas(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var bigIdeaForSocialStudies = _lookupManager.GetBigIdeaForSocialStudies();
            ViewData["BigIdeaForSocialStudiesList"] = new SelectList(bigIdeaForSocialStudies, "Id", "Name");

            return View(section);
        }

        // GET: /Section/OtherBigIdeas/SectionType
        public ActionResult OtherBigIdeas(string currentSectionType)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            if (currentSectionType == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionManager.GetSection(currentGradeLevel, CurrentYear, currentSectionType);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _sectionManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}