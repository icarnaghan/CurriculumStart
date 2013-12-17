﻿using System;
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
    public class StaCollectionController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();

        // GET: /StaCollection/Create
        public ActionResult Create(int id)
        {
            ViewBag.CaseStudyId = id;
            return View();
        }

        // POST: /StaCollection/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,CaseStudyId")] StaCollection stacollection)
        {
            if (ModelState.IsValid)
            {
                db.StaCollections.Add(stacollection);
                db.SaveChanges();
                return RedirectToAction("Edit", "CaseStudy", new { id=stacollection.CaseStudyId });
            }

            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", stacollection.CaseStudyId);
            return View(stacollection);
        }

        // GET: /StaCollection/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaCollection stacollection = db.StaCollections.Find(id);
            if (stacollection == null)
            {
                return HttpNotFound();
            }
            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", stacollection.CaseStudyId);
            return View(stacollection);
        }

        // POST: /StaCollection/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,CaseStudyId")] StaCollection stacollection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stacollection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CaseStudyId = new SelectList(db.CaseStudies, "Id", "Name", stacollection.CaseStudyId);
            return View(stacollection);
        }

        // GET: /StaCollection/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaCollection stacollection = db.StaCollections.Find(id);
            if (stacollection == null)
            {
                return HttpNotFound();
            }
            return View(stacollection);
        }

        // POST: /StaCollection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StaCollection stacollection = db.StaCollections.Find(id);
            db.StaCollections.Remove(stacollection);
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
