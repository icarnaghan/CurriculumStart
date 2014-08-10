using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Microsoft.Owin.Security.Provider;

namespace Mapper21.UI.Controllers
{
    public class UnitController : BaseController
    {
        private readonly ISubSectionRepository _subSectionRepository;
        private readonly ISectionRepository _sectionRepository;

        public UnitController(ISubSectionRepository subSectionRepository,
                                    ISectionRepository sectionRepository)
        {
            _subSectionRepository = subSectionRepository;
            _sectionRepository = sectionRepository;
        }

        // GET: /Unit/Create
        public ActionResult Create(int sectionId)
        {
            var subSectionType = GetSubSectionType(sectionId);

            ViewBag.SubSectionType = subSectionType;
            ViewBag.SectionId = sectionId;
            return View();
        }

        // POST: /Unit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubSection subSection)
        {
            if (ModelState.IsValid)
            {
                subSection.SubSectionTypeId = GetSubSectionType(subSection.SectionId);
                _subSectionRepository.InsertorUpdate(subSection);
                _subSectionRepository.Save();
                return RedirectToAction("Edit", "Unit", new { subSection.Id });
            }

            return View(subSection);
        }

        // GET: /Unit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var subSection = _subSectionRepository.Find(id);
            var subSectionType = GetSubSectionType(subSection.SectionId);

            ViewBag.SubSectionType = subSectionType;

            List<SubSectionStaGrid> staGrid = _subSectionRepository.GetStaGrids(id).ToList();

            ViewBag.staGrid = staGrid;

            return View(subSection);
        }

        // POST: /Unit/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubSection subSection)
        {
            if (ModelState.IsValid)
            {
                _subSectionRepository.InsertorUpdate(subSection);
                _subSectionRepository.Save();
                return RedirectToAction("Edit", "Unit", new { id = subSection.SectionId });
            }
            return View(subSection);
        }

        public int GetSubSectionType(int sectionId)
        {
            var section = _sectionRepository.Find(sectionId);
            switch (section.SectionTypeId)
            {
                case 1: // First Six Weeks
                    return 1; // Return Week Type
                case 5: // Strand
                    return 3; // Return Unit Type
                default: 
                    return 2; // Return Case Study Type
            }
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