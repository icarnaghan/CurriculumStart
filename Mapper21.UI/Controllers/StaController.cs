using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Provider;
using Mapper21.UI.Models;

namespace Mapper21.UI.Controllers
{
    public class StaController : Controller
    {
        private readonly Mapper21Context db = new Mapper21Context();

        // GET: /Sta/Create
        public ActionResult Create(int id)
        {
            ViewBag.SubSectionId = id;
            return View();
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
                var subSectionLongTermTarget = new SubSectionLongTermTarget {SubSectionStaId = subSectionSta.Id};
                db.SubSectionStas.Add(subSectionSta);
                db.SubSectionLongTermTargets.Add(subSectionLongTermTarget);
                db.SaveChanges();
                return RedirectToAction("Edit", "Sta", new {id = subSectionSta.Id});
            }

            ViewBag.CaseStudyId = new SelectList(db.SubSections, "Id", "Name", subSectionSta.SubSectionId);
            return View(subSectionSta);
        }

        // GET: /Sta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            SubSectionSta subSectionSta = db.SubSectionStas.Find(id);
            SubSectionLongTermTarget longTermTarget = db.SubSectionLongTermTargets.FirstOrDefault(l => l.SubSectionStaId == subSectionSta.Id);
            ICollection<CommonCoreStandard> commonCore = db.CommonCoreStandards.ToList();

            if (subSectionSta == null)
            {
                return HttpNotFound();
            }

            var subSectionStaViewModel = new SubSectionStaViewModel
            {
                SubSectionSta = new SubSectionSta {Id = subSectionSta.Id, SubSectionId = subSectionSta.SubSectionId},
                SubSectionLongTermTarget = longTermTarget,
                CommonCoreStandards = commonCore
            };

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
                subSectionStaViewModel.SubSectionLongTermTarget.SubSectionStaId =
                    subSectionStaViewModel.SubSectionSta.Id;
                db.Entry(subSectionStaViewModel.SubSectionLongTermTarget).State = EntityState.Modified;
                //db.SubSectionLongTermTargets.Add(subSectionStaViewModel.SubSectionLongTermTarget);
                db.SaveChanges();
                return RedirectToAction("Edit", "Sta", new { id = subSectionStaViewModel.SubSectionSta.Id });
            }

            return RedirectToAction("Edit", "SubSection", new {id = subSectionStaViewModel.SubSectionSta.SubSectionId});
        }

        // GET: /Sta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubSectionSta subSectionSta = db.SubSectionStas.Find(id);
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
            SubSectionSta subSectionSta = db.SubSectionStas.Find(id);
            db.SubSectionStas.Remove(subSectionSta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}