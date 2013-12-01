using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.DAL;

namespace ExpeditionMapper.Controllers
{
    public class FallExpeditionController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();

        // GET: /FallExpedition/
        public ActionResult Index()
        {
            var programs = db.Programs.OfType<FallExpedition>().Include(f => f.GradeLevel).Include(f => f.BigIdeasScience);
            return View(programs.ToList());
        }

        // GET: /FallExpedition/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FallExpedition fallexpedition = db.Programs.Find(id) as FallExpedition;
            if (fallexpedition == null)
            {
                return HttpNotFound();
            }
            return View(fallexpedition);
        }

        // GET: /FallExpedition/Create
        public ActionResult Create()
        {
            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name");
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas, "Id", "Name");
            return View();
        }

        // POST: /FallExpedition/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Year,GradeLevelId,Name,Description,BigIdeasId")] FallExpedition fallexpedition)
        {
            if (ModelState.IsValid)
            {
                db.Programs.Add(fallexpedition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name", fallexpedition.GradeLevelId);
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas, "Id", "Name", fallexpedition.BigIdeasId);
            return View(fallexpedition);
        }

        // GET: /FallExpedition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FallExpedition fallexpedition = db.Programs.Find(id) as FallExpedition;
            if (fallexpedition == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name", fallexpedition.GradeLevelId);
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas.OfType<BigIdeasScience>(), "Id", "Name", fallexpedition.BigIdeasId);
            return View(fallexpedition);
        }

        // POST: /FallExpedition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Year,GradeLevelId,Name,Description,BigIdeasId")] FallExpedition fallexpedition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fallexpedition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name", fallexpedition.GradeLevelId);
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas, "Id", "Name", fallexpedition.BigIdeasId);
            return View(fallexpedition);
        }

        // GET: /FallExpedition/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FallExpedition fallexpedition = db.Programs.Find(id) as FallExpedition;
            if (fallexpedition == null)
            {
                return HttpNotFound();
            }
            return View(fallexpedition);
        }

        // POST: /FallExpedition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FallExpedition fallexpedition = db.Programs.Find(id) as FallExpedition;
            db.Programs.Remove(fallexpedition);
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
