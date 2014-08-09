using System.Net;
using System.Web.Mvc;
using Mapper21.BE.Domain;
using Mapper21.DAL.Provider;

namespace Mapper21.UI.Controllers
{
    public class StaCollectionController : Controller
    {
        private readonly Mapper21Context db = new Mapper21Context();

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
        public ActionResult Create([Bind(Include = "Id,CaseStudyId")] SubSectionSta stacollection)
        {
            if (ModelState.IsValid)
            {
                db.StaCollections.Add(stacollection);
                db.SaveChanges();
                return RedirectToAction("Edit", "StaCollection", new {id = stacollection.Id});
            }

            ViewBag.CaseStudyId = new SelectList(db.SubSections, "Id", "Name", stacollection.SubSectionId);
            return View(stacollection);
        }

        // GET: /StaCollection/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubSectionSta stacollection = db.StaCollections.Find(id);
            if (stacollection == null)
            {
                return HttpNotFound();
            }

            return View(stacollection);
        }

        // POST: /StaCollection/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CaseStudyId")] SubSectionSta stacollection)
        {
            return RedirectToAction("Edit", "CaseStudy", new {id = stacollection.SubSectionId});
        }

        // GET: /StaCollection/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubSectionSta stacollection = db.StaCollections.Find(id);
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
            SubSectionSta stacollection = db.StaCollections.Find(id);
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