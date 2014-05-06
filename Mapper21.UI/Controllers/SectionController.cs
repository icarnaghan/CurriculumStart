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
        private readonly ICaseStudyRepository _caseStudyRepository;

        public SectionController(ISectionRepository sectionRepository, ICaseStudyRepository caseStudyRepository)
        {
            _sectionRepository = sectionRepository;
            _caseStudyRepository = caseStudyRepository;
        }

        // GET: /Section/CaseStudy/
        public ActionResult CaseStudy(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            section.CaseStudies = _caseStudyRepository.GetAllBySection(id).ToList();
            return View(section);
        }

        // GET: /Section/FinalProduct/5
        public ActionResult FinalProduct(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /Section/FinalProduct/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinalProduct(Section section)
        {
            if (ModelState.IsValid)
            {
                section.GradeLevelId = 2;
                _sectionRepository.InsertorUpdate(section);
                _sectionRepository.Save();

                return RedirectToAction("Index", "Home");
            }
            return View(section);
        }

        // GET: /Section/Overview/5
        public ActionResult Overview(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            ViewBag.Semester = "Fall";
            return View(section);
        }

        // POST: /Section/Overview/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(Section section)
        {
            if (ModelState.IsValid)
            {
                section.GradeLevelId = 2;
                _sectionRepository.InsertorUpdate(section);
                _sectionRepository.Save();
            }
            return View(section);
        }

        // GET: /Section/GuidingQuestions/5
        public ActionResult GuidingQuestions(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/Habits/5
        public ActionResult Habits(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/ScienceBigIdeas/5
        public ActionResult ScienceBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /Section/SocialStudiesBigIdeas/5
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