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
using ExpeditionMapper.Models.Domain.LookUps;
using ExpeditionMapper.Models.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ExpeditionMapper.Controllers
{
    public class FallExpeditionController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();

        // GET: /FallExpedition/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Expedition_Read([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<FallExpedition> programs = db.Programs.OfType<FallExpedition>();
            return Json(programs.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Expedition_Create([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<FallExpedition> expeditions)
        {
            // Will keep the inserted entitites here. Used to return the result later.
            var entities = new List<FallExpedition>();
            if (ModelState.IsValid)
            {
                foreach (var expedition in expeditions)
                {
                    // Create a new Expedition entity and set its properties from the posted FallExpedition Model
                    var entity = new FallExpedition
                    {
                        Id = expedition.Id,
                        Year = expedition.Year,
                        Name = expedition.Name,
                        Description = expedition.Description,
                        GradeLevelId = expedition.GradeLevelId,
                        BigIdeasId = expedition.BigIdeasId
                    };
                    // Add the entity
                    db.Programs.Add(entity);
                    // Store the entity for later use
                    entities.Add(entity);
                }
                // Insert the entities in the database
                db.SaveChanges();
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(entities.ToDataSourceResult(request, ModelState, expedition => new ExpeditionViewModel
            {
                Id = expedition.Id,
                Year = expedition.Year,
                Name = expedition.Name,
                Description = expedition.Description,
                GradeLevelId = expedition.GradeLevelId,
                BigIdeasId = expedition.BigIdeasId
            }));
        }


        public ActionResult FallExpeditions_Update([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ExpeditionViewModel> expeditions)
        {
            // Will keep the updated entitites here. Used to return the result later.
            var entities = new List<FallExpedition>();
            if (ModelState.IsValid)
            {
                foreach (var expedition in expeditions)
                {
                    // Create a new Product entity and set its properties from the posted ExpeditionViewModel
                    var entity = new FallExpedition
                    {
                        Id = expedition.Id,
                        Year = expedition.Year,
                        Name = expedition.Name,
                        Description = expedition.Description,
                        GradeLevelId = expedition.GradeLevelId,
                        BigIdeasId = expedition.BigIdeasId
                    };
                    // Store the entity for later use
                    entities.Add(entity);
                    // Attach the entity
                    db.FallExpeditions.Attach(entity);
                    // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                    db.Entry(entity).State = EntityState.Modified;
                    // Or use ObjectStateManager if using a previous version of Entity Framework
                    // northwind.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                }
                // Update the entities in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(entities.ToDataSourceResult(request, ModelState, expedition => new ExpeditionViewModel
            {
                Id = expedition.Id,
                Year = expedition.Year,
                Name = expedition.Name,
                Description = expedition.Description,
                GradeLevelId = expedition.GradeLevelId,
                BigIdeasId = expedition.BigIdeasId
            }));
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
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas.OfType<BigIdeasSocialStudies>(), "Id", "Name");
            return View();
        }

        // POST: /FallExpedition/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Year,GradeLevelId,Name,Description,BigIdeasId")] FallExpedition fallexpedition)
        {
            if (ModelState.IsValid)
            {
                db.Programs.Add(fallexpedition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradeLevelId = new SelectList(db.GradeLevels, "Id", "Name", fallexpedition.GradeLevelId);
            ViewBag.BigIdeasId = new SelectList(db.BigIdeas.OfType<BigIdeasSocialStudies>(), "Id", "Name", fallexpedition.BigIdeasId);
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
        public ActionResult Edit([Bind(Include = "Id,Year,GradeLevelId,Name,Description,BigIdeasId")] FallExpedition fallexpedition)
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
