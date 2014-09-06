using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Mapper21.Business.Dto;
using Mapper21.Business.Dto.LookUps;
using Mapper21.Business.Interfaces;
using Mapper21.Domain;
using Mapper21.Site.Models;

namespace Mapper21.Site.Controllers
{
    public class StaController : BaseController
    {
        private readonly ISubSectionManager _subSectionManager;
        private readonly IStaManager _staManager;
        private readonly ILongTermTargetManager _longTermTargetManager;
        private readonly ILookupManager _lookupManager;

        public StaController(ISubSectionManager subSectionManager,
                                 IStaManager staManager,
                                 ILongTermTargetManager longTermTargetManager,
                                 ILookupManager lookupManager)
        {
            _subSectionManager = subSectionManager;
            _staManager = staManager;
            _longTermTargetManager = longTermTargetManager;
            _lookupManager = lookupManager;
        }

        // GET: /Sta/Create
        public ActionResult Create(string currentSectionType, Guid subSectionId)
        {
            var subSectionSta = new SubSectionStaDto
            {
                SubSectionId = subSectionId,
            };

            ViewBag.SectionId = _subSectionManager.Find(subSectionId).SectionId;
            return View(subSectionSta);
        }

        // POST: /Sta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SubSectionId")] SubSectionStaDto subSectionSta)
        {
            if (ModelState.IsValid)
            {
                var newSubSectionSta = _staManager.SaveOrUpdate(subSectionSta);

                var subSectionLongTermTarget = new SubSectionLongTermTargetDto { SubSectionStaId = newSubSectionSta.Id };
                _longTermTargetManager.SaveOrUpdate(subSectionLongTermTarget);
                return RedirectToAction("Edit", "Sta", new { id = newSubSectionSta.Id });
            }
            return View(subSectionSta);
        }

        // GET: /Sta/Edit/5
        public ActionResult Edit(string currentSectionType, Guid subsectionId, Guid id)
        {
            var currentGradeLevel = CurrentGradeLevel == "" ? Session["GradeLevel"].ToString() : CurrentGradeLevel;
            var subSectionSta = _staManager.Find(id);
            if (subSectionSta == null) return HttpNotFound();
            
            var longTermTarget = _longTermTargetManager.GetAll().FirstOrDefault(l => l.SubSectionStaId == subSectionSta.Id);
            ICollection<CommonCoreStandardLookupDto> standard = _lookupManager.GetCommonCoreStandards().Where(s => s.GradeLevelId == currentGradeLevel).ToList();
            var subSectionStaViewModel = new SubSectionStaViewModel
            {
                SubSectionSta = new SubSectionStaDto {Id = subSectionSta.Id, SubSectionId = subSectionSta.SubSectionId},
                SubSectionLongTermTarget = longTermTarget,
                CommonCoreStandards = standard.ToList()
            };

            foreach (var item in standard)
            {
                var newName = item.Name;
                if (item.Name.Length >= 70) newName = item.Name.Substring(0, 70);
                item.Name = item.Subject + item.Code + " (" + newName + " . . . )";
            }

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
                _longTermTargetManager.SaveOrUpdate(subSectionStaViewModel.SubSectionLongTermTarget);
                return RedirectToAction("Edit", "Sta", new { id = subSectionStaViewModel.SubSectionSta.Id });
            }
            return RedirectToAction("Edit", "Sta", new { id = subSectionStaViewModel.SubSectionSta.Id });
        }

        // GET: /Sta/Delete/5
        public ActionResult Delete(Guid id)
        {
            SubSectionStaDto subSectionSta = _staManager.Find(id);
            if (subSectionSta == null)
            {
                return HttpNotFound();
            }
            return View(subSectionSta);
        }

        // POST: /Sta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _staManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}