using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Interfaces;
using Mapper21.UI.Models;

namespace Mapper21.UI.Controllers
{
    public class StaController : BaseController
    {
        private readonly ISubSectionRepository _subSectionRepository;
        private readonly ISubSectionStaRepository _subSectionStaRepository;
        private readonly ISubSectionLongTermTargetRepository _subSectionLongTermTargetRepository;
        private readonly ILookupRepository _lookupRepository;

        public StaController(ISubSectionRepository subSectionRepository,
                                 ISubSectionStaRepository subSectionStaRepository,
                                 ISubSectionLongTermTargetRepository subSectionLongTermTargetRepository,
                                 ILookupRepository lookupRepository)
        {
            _subSectionRepository = subSectionRepository;
            _subSectionStaRepository = subSectionStaRepository;
            _subSectionLongTermTargetRepository = subSectionLongTermTargetRepository;
            _lookupRepository = lookupRepository;
        }

        // GET: /Sta/Create
        public ActionResult Create(int subSectionId)
        {
            var subSectionSta = new SubSectionSta
            {
                SubSectionId = subSectionId,
            };

            ViewBag.SectionId = _subSectionRepository.Find(subSectionId).SectionId;
            return View(subSectionSta);
        }

        // POST: /Sta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SubSectionId")] SubSectionSta subSectionSta)
        {
            if (ModelState.IsValid)
            {
                _subSectionStaRepository.InsertorUpdate(subSectionSta);
                _subSectionStaRepository.Save();

                var subSectionLongTermTarget = new SubSectionLongTermTarget { SubSectionStaId = subSectionSta.Id };
                _subSectionLongTermTargetRepository.InsertorUpdate(subSectionLongTermTarget);
                _subSectionLongTermTargetRepository.Save();
                return RedirectToAction("Edit", "Sta", new {id = subSectionSta.Id});
            }
            return View(subSectionSta);
        }

        // GET: /Sta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var subSectionSta = _subSectionStaRepository.Find(id);
            if (subSectionSta == null) return HttpNotFound();
            
            var longTermTarget = _subSectionLongTermTargetRepository.GetAll().FirstOrDefault(l => l.SubSectionStaId == subSectionSta.Id);
            ICollection<CommonCoreStandard> standard = _lookupRepository.GetCommonCoreStandards().Where(s => s.GradeLevelId == CurrentGradeLevel).ToList();
            var subSectionStaViewModel = new SubSectionStaViewModel
            {
                SubSectionSta = new SubSectionSta {Id = subSectionSta.Id, SubSectionId = subSectionSta.SubSectionId},
                SubSectionLongTermTarget = longTermTarget,
                CommonCoreStandards = standard
            };

            // Get SelectList
            ViewData["StandardList"] = new SelectList(standard, "Id", "Name");

            return View(subSectionStaViewModel);
        }

        // POST: /Sta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubSectionStaViewModel subSectionStaViewModel)
        {
            if (ModelState.IsValid)
            {
                subSectionStaViewModel.SubSectionLongTermTarget.SubSectionStaId = subSectionStaViewModel.SubSectionSta.Id;
                _subSectionLongTermTargetRepository.InsertorUpdate(subSectionStaViewModel.SubSectionLongTermTarget);
                _subSectionLongTermTargetRepository.Save();
                return RedirectToAction("Edit", "Sta", new { id = subSectionStaViewModel.SubSectionSta.Id });
            }
            return RedirectToAction("Edit", "Sta", new { id = subSectionStaViewModel.SubSectionSta.Id });
        }

        // GET: /Sta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubSectionSta subSectionSta = _subSectionStaRepository.Find(id);
            if (subSectionSta == null)
            {
                return HttpNotFound();
            }
            return View(subSectionSta);
        }

        // POST: /Sta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _subSectionStaRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}