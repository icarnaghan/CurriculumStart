using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.BE.Domain;
using ExpeditionMapper.DAL;

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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var expedition = _expeditionRepository.Find(id);
            if (expedition == null)
            {
                return HttpNotFound();
            }
            expedition.CaseStudies = _caseStudyRepository.GetAllByExpedition(id).ToList();
            return View(expedition);
        }

        // POST: /Expedition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(
                Include =
                    "Id,Year,GradeLevelId,Name,Description,KickOff,FinalProductName,FinalProductDescription,GuidingQuestions"
                )] Expedition expedition)
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