using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.DAL;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.Controllers
{
    public class CCController : Controller
    {
        private readonly ExpeditionContext db = new ExpeditionContext();

        // GET: /CC/
        public ActionResult Index()
        {
            IQueryable<CaseStudy> casestudies = db.CaseStudies.Include(c => c.Expedition);
            return View(casestudies.ToList());
        }

        // GET: /CC/Details/5
        public ActionResult Details(int? id)
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
            return View(casestudy);
        }

        // GET: /CC/Create
        public ActionResult Create()
        {
            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name");
            return View();
        }

        // POST: /CC/Create
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
                return RedirectToAction("Index");
            }

            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name", casestudy.ExpeditionId);
            return View(casestudy);
        }

        // GET: /CC/Edit/5
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
            return View(casestudy);
        }

        // POST: /CC/Edit/5
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
                return RedirectToAction("Index");
            }
            ViewBag.ExpeditionId = new SelectList(db.Expeditions, "Id", "Name", casestudy.ExpeditionId);
            return View(casestudy);
        }

        // GET: /CC/Delete/5
        public ActionResult Delete(int? id)
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
            return View(casestudy);
        }

        // POST: /CC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CaseStudy casestudy = db.CaseStudies.Find(id);
            db.CaseStudies.Remove(casestudy);
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