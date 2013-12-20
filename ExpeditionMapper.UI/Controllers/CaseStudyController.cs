using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.BE.Domain;
using ExpeditionMapper.DAL.Provider;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.UI.Controllers
{
    public class CaseStudyController : BaseController
    {
        private readonly ExpeditionContext db = new ExpeditionContext();

        // GET: /CS/Create
        public ActionResult Create(int Id)
        {
            ViewBag.ExpeditionId = Id;
            return View();
        }

        // POST: /CS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExpeditionId,Name,Description")] CaseStudy casestudy)
        {
            if (ModelState.IsValid)
            {
                db.CaseStudies.Add(casestudy);
                db.SaveChanges();
                return RedirectToAction("Edit", "CaseStudy", new {casestudy.Id});
            }

            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name", casestudy.ExpeditionId);
            return View(casestudy);
        }


        // GET: /CaseStudy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaseStudy casestudy = db.CaseStudies.Find(id);
            if (casestudy == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name", casestudy.ExpeditionId);

            List<StaGrid> staGrid = db.StaGrid.Where(s => s.CaseStudyId == id).ToList();

            ViewBag.staGrid = staGrid;

            return View(casestudy);
        }

        // POST: /CaseStudy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExpeditionId,Name,Description")] CaseStudy casestudy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(casestudy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "Expedition", new {id = casestudy.ExpeditionId});
            }
            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name", casestudy.ExpeditionId);
            return View(casestudy);
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