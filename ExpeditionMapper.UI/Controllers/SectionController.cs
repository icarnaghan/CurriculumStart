using System.Linq;
using System.Net;
using System.Web.Mvc;
using FlexMapper.BE.Domain;
using FlexMapper.DAL.Interfaces;

namespace FlexMapper.UI.Controllers
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

        // GET: /Section/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var section = _sectionRepository.Find(id);
            
            if (section == null) return HttpNotFound();
            
            section.CaseStudies = _caseStudyRepository.GetAllByExpedition(id).ToList();
            
            return View(section);
        }

        // POST: /Section/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Section section)
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