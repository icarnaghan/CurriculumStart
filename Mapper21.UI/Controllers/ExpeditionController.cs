using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;

namespace Mapper21.UI.Controllers
{
    public class ExpeditionController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ISubSectionRepository _caseStudyRepository;

        public ExpeditionController(ISectionRepository sectionRepository, ISubSectionRepository caseStudyRepository)
        {
            _sectionRepository = sectionRepository;
            _caseStudyRepository = caseStudyRepository;
        }

        // GET: /Expedition/CaseStudy/5
        public ActionResult CaseStudy(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Expedition/FinalProduct/5
        public ActionResult FinalProduct(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /Expedition/FinalProduct/5
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

        // GET: /Expedition/Overview/5
        public ActionResult Overview(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            return View(section);
        }

        // POST: /Expedition/Overview/5
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

        // GET: /Expedition/GuidingQuestions/5
        public ActionResult GuidingQuestions(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Expedition/Habits/5
        public ActionResult Habits(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();

            // Get SelectList
            var habit = _sectionRepository.GetHabits();
            ViewData["HabitList"] = new SelectList(habit, "Id", "Name");

            return View(section);
        }

        // GET: /Expedition/ScienceBigIdeas/5
        public ActionResult ScienceBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Expedition/SocialStudiesBigIdeas/5
        public ActionResult SocialStudiesBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
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