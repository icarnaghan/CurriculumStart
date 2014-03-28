using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.BE.Domain;
using ExpeditionMapper.DAL.Interfaces;

namespace ExpeditionMapper.UI.Controllers
{
    public class ExpeditionController : BaseController
    {
        private readonly IExpeditionRepository _expeditionRepository;
        private readonly ICaseStudyRepository _caseStudyRepository;

        public ExpeditionController(IExpeditionRepository expeditionRepository, ICaseStudyRepository caseStudyRepository)
        {
            _expeditionRepository = expeditionRepository;
            _caseStudyRepository = caseStudyRepository;
        }

        // GET: /Expedition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var expedition = _expeditionRepository.Find(id);
            
            if (expedition == null) return HttpNotFound();
            
            expedition.CaseStudies = _caseStudyRepository.GetAllByExpedition(id).ToList();
            
            return View(expedition);
        }

        // POST: /Expedition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Expedition expedition)
        {
            if (ModelState.IsValid)
            {
                expedition.GradeLevelId = 2;
                _expeditionRepository.InsertorUpdate(expedition);
                _expeditionRepository.Save();

                return RedirectToAction("Index", "Home");
            }
            return View(expedition);
        }

        // GET: /Expedition/Overview/5
        public ActionResult Overview(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var expedition = _expeditionRepository.Find(id);
            if (expedition == null) return HttpNotFound();

            ViewBag.Title = expedition.Name;
            ViewBag.Semester = "Fall";
            return View(expedition);
        }

        // POST: /Expedition/Overview/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(Expedition expedition)
        {
            if (ModelState.IsValid)
            {
                expedition.GradeLevelId = 2;
                _expeditionRepository.InsertorUpdate(expedition);
                _expeditionRepository.Save();
            }
            return View(expedition);
        }

        // GET: /Expedition/GuidingQuestions/5
        public ActionResult GuidingQuestions(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var expedition = _expeditionRepository.Find(id);
            if (expedition == null) return HttpNotFound();
            return View(expedition);
        }

        // GET: /Expedition/Habits/5
        public ActionResult Habits(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var expedition = _expeditionRepository.Find(id);
            if (expedition == null) return HttpNotFound();
            return View(expedition);
        }

        // GET: /Expedition/ScienceBigIdeas/5
        public ActionResult ScienceBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var expedition = _expeditionRepository.Find(id);
            if (expedition == null) return HttpNotFound();
            return View(expedition);
        }

        // GET: /Expedition/SocialStudiesBigIdeas/5
        public ActionResult SocialStudiesBigIdeas(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var expedition = _expeditionRepository.Find(id);
            if (expedition == null) return HttpNotFound();
            return View(expedition);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _expeditionRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}