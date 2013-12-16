﻿using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ExpeditionMapper.DAL;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.Models.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ExpeditionMapper.Controllers
{
    public class ScienceBigIdeaController : BaseController
    {
        private readonly ExpeditionContext db = new ExpeditionContext();

        public ActionResult ScienceBigIdea_Read(int expeditionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<ScienceBigIdea> scienceBigIdeas = db.ScienceBigIdeases.Where(b => b.ExpeditionId == expeditionId);
            return Json(scienceBigIdeas.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ScienceBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            ScienceBigIdeaViewModel scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Expedition entity and set its properties from the posted FallExpedition Model
                var entity = new ScienceBigIdea
                {
                    Id = scienceBigIdea.Id,
                    Idea = scienceBigIdea.Idea,
                    Rationale = scienceBigIdea.Rationale,
                    ExpeditionId = scienceBigIdea.ExpeditionId
                };
                // Add the entity
                db.ScienceBigIdeases.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                scienceBigIdea.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {scienceBigIdea}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ScienceBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            ScienceBigIdeaViewModel scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ExpeditionViewModel
                var entity = new ScienceBigIdea
                {
                    Id = scienceBigIdea.Id,
                    Idea = scienceBigIdea.Idea,
                    Rationale = scienceBigIdea.Rationale,
                    ExpeditionId = scienceBigIdea.ExpeditionId
                };
                // Attach the entity
                db.ScienceBigIdeases.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] {scienceBigIdea}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ScienceBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            ScienceBigIdeaViewModel scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new ScienceBigIdea
                {
                    Id = scienceBigIdea.Id,
                    Idea = scienceBigIdea.Idea,
                    Rationale = scienceBigIdea.Rationale,
                    ExpeditionId = scienceBigIdea.ExpeditionId
                };
                // Attach the entity
                db.ScienceBigIdeases.Attach(entity);
                // Delete the entity
                db.ScienceBigIdeases.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] {scienceBigIdea}.ToDataSourceResult(request, ModelState));
        }
    }
}