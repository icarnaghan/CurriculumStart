﻿using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ExpeditionMapper.BE.Domain;
using ExpeditionMapper.DAL.Provider;
using ExpeditionMapper.UI.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ExpeditionMapper.UI.Controllers
{
    public class FieldworkController : BaseController
    {
        private readonly ExpeditionContext db = new ExpeditionContext();

        public ActionResult Fieldwork_Read(int caseStudyId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<Fieldwork> fieldwork = db.Fieldworks.Where(f => f.CaseStudyId == caseStudyId);
            return Json(fieldwork.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Fieldwork_Create([DataSourceRequest] DataSourceRequest request, FieldworkViewModel fieldwork)
        {
            if (ModelState.IsValid)
            {
                // Create a new Expedition entity and set its properties from the posted FallExpedition Model
                var entity = new Fieldwork
                {
                    Id = fieldwork.Id,
                    Name = fieldwork.Name,
                    Description = fieldwork.Description,
                    CaseStudyId = fieldwork.CaseStudyId
                };
                // Add the entity
                db.Fieldworks.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                fieldwork.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {fieldwork}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Fieldwork_Update([DataSourceRequest] DataSourceRequest request, FieldworkViewModel fieldwork)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ExpeditionViewModel
                var entity = new Fieldwork
                {
                    Id = fieldwork.Id,
                    Name = fieldwork.Name,
                    Description = fieldwork.Description,
                    CaseStudyId = fieldwork.CaseStudyId
                };
                // Attach the entity
                db.Fieldworks.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] {fieldwork}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Fieldwork_Destroy([DataSourceRequest] DataSourceRequest request,
            FieldworkViewModel fieldwork)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new Fieldwork
                {
                    Id = fieldwork.Id,
                    Name = fieldwork.Name,
                    Description = fieldwork.Description,
                    CaseStudyId = fieldwork.CaseStudyId
                };
                // Attach the entity
                db.Fieldworks.Attach(entity);
                // Delete the entity
                db.Fieldworks.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] {fieldwork}.ToDataSourceResult(request, ModelState));
        }
    }
}