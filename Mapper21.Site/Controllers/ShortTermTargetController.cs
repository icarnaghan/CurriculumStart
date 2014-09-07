﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Mapper21.Business.Dto;
using Mapper21.Data.Provider;
using Mapper21.Domain;

namespace Mapper21.Site.Controllers
{
    public class ShortTermTargetController : BaseController
    {
        private readonly Mapper21Context db = new Mapper21Context();

        public ActionResult ShortTermTarget_Read(Guid subSectionStaId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<SubSectionShortTermTarget> shortTermTargets =
                db.SubSectionShortTermTargets.Where(h => h.SubSectionStaId == subSectionStaId);
            return Json(shortTermTargets.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ShortTermTarget_Create([DataSourceRequest] DataSourceRequest request,
            GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                // Create a new Section entity and set its properties from the posted Section Model
                var entity = new SubSectionShortTermTarget
                {
                    Id = Guid.NewGuid(),
                    Name = shortTermTarget.Name,
                    SubSectionStaId = shortTermTarget.ParentId
                };
                // Add the entity
                db.SubSectionShortTermTargets.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                shortTermTarget.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {shortTermTarget}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ShortTermTarget_Update([DataSourceRequest] DataSourceRequest request,
            GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted SectionViewModel
                var entity = new SubSectionShortTermTarget
                {
                    Id = shortTermTarget.Id,
                    Name = shortTermTarget.Name,
                    SubSectionStaId = shortTermTarget.ParentId
                };
                // Attach the entity
                db.SubSectionShortTermTargets.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] {shortTermTarget}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ShortTermTarget_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new SubSectionShortTermTarget
                {
                    Id = shortTermTarget.Id,
                    Name = shortTermTarget.Name,
                    SubSectionStaId = shortTermTarget.ParentId
                };
                // Attach the entity
                db.SubSectionShortTermTargets.Attach(entity);
                // Delete the entity
                db.SubSectionShortTermTargets.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] {shortTermTarget}.ToDataSourceResult(request, ModelState));
        }
    }
}