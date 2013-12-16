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
    public class StandardTargetAssessmentController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();

        // GET: /StandardTargetAssessment/
        public ActionResult Index()
        {
            var standardstargetsassessments = db.StandardsTargetsAssessments.Include(s => s.CaseStudy);
            return View(standardstargetsassessments.ToList());
        }

        // GET: /StandardTargetAssessment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardTargetAssessment standardtargetassessment = db.StandardsTargetsAssessments.Find(id);
            if (standardtargetassessment == null)
            {
                return HttpNotFound();
            }
            return View(standardtargetassessment);
        }

        // GET: /StandardTargetAssessment/Create
        public ActionResult Create()
        {
            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name");
            return View();
        }

        // POST: /StandardTargetAssessment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,CaseStudyId")] StandardTargetAssessment standardtargetassessment)
        {
            if (ModelState.IsValid)
            {
                db.StandardsTargetsAssessments.Add(standardtargetassessment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", standardtargetassessment.CaseStudyId);
            return View(standardtargetassessment);
        }

        // GET: /StandardTargetAssessment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardTargetAssessment standardtargetassessment = db.StandardsTargetsAssessments.Find(id);
            if (standardtargetassessment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", standardtargetassessment.CaseStudyId);
            return View(standardtargetassessment);
        }

        // POST: /StandardTargetAssessment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,CaseStudyId")] StandardTargetAssessment standardtargetassessment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(standardtargetassessment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", standardtargetassessment.CaseStudyId);
            return View(standardtargetassessment);
        }

        // GET: /StandardTargetAssessment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StandardTargetAssessment standardtargetassessment = db.StandardsTargetsAssessments.Find(id);
            if (standardtargetassessment == null)
            {
                return HttpNotFound();
            }
            return View(standardtargetassessment);
        }

        // POST: /StandardTargetAssessment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StandardTargetAssessment standardtargetassessment = db.StandardsTargetsAssessments.Find(id);
            db.StandardsTargetsAssessments.Remove(standardtargetassessment);
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
