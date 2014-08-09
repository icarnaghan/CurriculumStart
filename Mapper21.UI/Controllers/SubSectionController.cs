using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;

namespace Mapper21.UI.Controllers
{
    public class SubSectionController : BaseController
    {
        private readonly ISubSectionRepository _subSectionRepository;

        public SubSectionController(ISubSectionRepository subSectionRepository)
        {
            _subSectionRepository = subSectionRepository;
        }

        // GET: /CS/Create
        public ActionResult Create(int Id)
        {
            ViewBag.SectionId = Id;
            return View();
        }

        // POST: /CaseStudy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubSection casestudy)
        {
            if (ModelState.IsValid)
            {
                _subSectionRepository.InsertorUpdate(casestudy);
                _subSectionRepository.Save();
                return RedirectToAction("Edit", "CaseStudy", new {casestudy.Id});
            }

            return View(casestudy);
        }


        // GET: /CaseStudy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var casestudy = _subSectionRepository.Find(id);
            
            if (casestudy == null)
            {
                return HttpNotFound();
            }

            List<SubSectionStaGrid> staGrid = _subSectionRepository.GetStaGrids(id).ToList();

            ViewBag.staGrid = staGrid;

            return View(casestudy);
        }

        // POST: /CaseStudy/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubSection casestudy)
        {
            if (ModelState.IsValid)
            {
                _subSectionRepository.InsertorUpdate(casestudy);
                _subSectionRepository.Save();
                return RedirectToAction("Edit", "Section", new {id = casestudy.SectionId});
            }
            return View(casestudy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _subSectionRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}