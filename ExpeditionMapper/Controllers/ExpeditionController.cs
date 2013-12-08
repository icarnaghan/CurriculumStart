using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.DAL;

namespace ExpeditionMapper.Controllers
{
    public class ExpeditionController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();

        // GET: /Expedition/
        public ActionResult Index()
        {
            var expeditions = db.Expeditions.Include(e => e.GradeLevel).Include(e => e.GuidingQuestions);
            return View(expeditions.ToList());
        }

        [HttpPost]
        public ActionResult New(Expedition expedition)
        {
            if (ModelState.IsValid)
            {
                db.Expeditions.Add(expedition);
                db.SaveChanges();
            }
            return Redirect("New");
        }

        // GET: /Expedition/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expedition expedition = db.Expeditions.Find(id);
            if (expedition == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name", expedition.GradeLevelId);
            return View(expedition);
        }

        // POST: /Expedition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Year,GradeLevelId,Name,Description,KickOff,FinalProductName,FinalProductDescription,GuidingQuestions")] Expedition expedition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expedition).State = EntityState.Modified;
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(expedition);
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
