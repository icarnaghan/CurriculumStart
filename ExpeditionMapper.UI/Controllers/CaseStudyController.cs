using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FlexMapper.BE.Domain;
using FlexMapper.DAL.Interfaces;

namespace FlexMapper.UI.Controllers
{
    public class CaseStudyController : BaseController
    {
        private readonly ICaseStudyRepository _caseStudyRepository;

        public CaseStudyController(ICaseStudyRepository caseStudyRepository)
        {
            _caseStudyRepository = caseStudyRepository;
        }

        // GET: /CS/Create
        public ActionResult Create(int Id)
        {
            ViewBag.ExpeditionId = Id;
            return View();
        }

        // POST: /CaseStudy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CaseStudy casestudy)
        {
            if (ModelState.IsValid)
            {
                _caseStudyRepository.InsertorUpdate(casestudy);
                _caseStudyRepository.Save();
                return RedirectToAction("Edit", "CaseStudy", new {casestudy.Id});
            }

            return View(casestudy);
        }


        // GET: /CaseStudy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var casestudy = _caseStudyRepository.Find(id);
            
            if (casestudy == null)
            {
                return HttpNotFound();
            }

            List<StaGrid> staGrid = _caseStudyRepository.GetStaGrids(id).ToList();

            ViewBag.staGrid = staGrid;

            return View(casestudy);
        }

        // POST: /CaseStudy/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CaseStudy casestudy)
        {
            if (ModelState.IsValid)
            {
                _caseStudyRepository.InsertorUpdate(casestudy);
                _caseStudyRepository.Save();
                return RedirectToAction("Edit", "Expedition", new {id = casestudy.SectionId});
            }
            return View(casestudy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _caseStudyRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}