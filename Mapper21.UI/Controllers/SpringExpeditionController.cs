using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;

namespace Mapper21.UI.Controllers
{
    public class SpringExpeditionController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ISubSectionRepository _subSectionRepository;

        public SpringExpeditionController(ISectionRepository sectionRepository, ISubSectionRepository subSectionRepository)
        {
            _sectionRepository = sectionRepository;
            _subSectionRepository = subSectionRepository;
        }

        // GET: /SpringExpedition/CaseStudy/5
        public ActionResult CaseStudy(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            section.SubSections = _subSectionRepository.GetAllBySection(id).ToList();
            return View(section);
        }

        // GET: /SpringExpedition/FinalProduct/5
        public ActionResult FinalProduct(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // POST: /SpringExpedition/FinalProduct/5
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

        // GET: /SpringExpedition/Overview/5
        public ActionResult Overview(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();

            ViewBag.Title = section.Name;
            return View(section);
        }

        // POST: /SpringExpedition/Overview/5
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

        // GET: /SpringExpedition/GuidingQuestions/5
        public ActionResult GuidingQuestions(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /SpringExpedition/Habits/5
        public ActionResult Habits(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /SpringExpedition/ScienceBigIdeas/5
        public ActionResult ScienceBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var section = _sectionRepository.Find(id);
            if (section == null) return HttpNotFound();
            return View(section);
        }

        // GET: /SpringExpedition/SocialStudiesBigIdeas/5
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