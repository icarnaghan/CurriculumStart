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
    public class SocialStudiesBigIdeaController : BaseController
    {
        private readonly Mapper21Context db = new Mapper21Context();

        public ActionResult SocialStudiesBigIdea_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<SectionSocialStudiesBigIdea> socialStudiesBigIdeas =
                db.SectionSocialStudiesBigIdeas.Where(b => b.SectionId == sectionId);
            return Json(socialStudiesBigIdeas.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SocialStudiesBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            GridSelectSocialStudiesBigIdeaDto socialStudiesBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Section entity and set its properties from the posted Section Model
                var entity = new SectionSocialStudiesBigIdea
                {
                    Id = Guid.NewGuid(),
                    BigIdeaForSocialStudiesId = socialStudiesBigIdea.BigIdeaForSocialStudiesId,
                    Context = socialStudiesBigIdea.Context,
                    SectionId = socialStudiesBigIdea.ParentId
                };
                // Add the entity
                db.SectionSocialStudiesBigIdeas.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                socialStudiesBigIdea.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {socialStudiesBigIdea}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SocialStudiesBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            GridSelectSocialStudiesBigIdeaDto socialStudiesBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted Section Model
                var entity = new SectionSocialStudiesBigIdea
                {
                    Id = socialStudiesBigIdea.Id,
                    BigIdeaForSocialStudiesId = socialStudiesBigIdea.BigIdeaForSocialStudiesId,
                    Context = socialStudiesBigIdea.Context,
                    SectionId = socialStudiesBigIdea.ParentId
                };
                // Attach the entity
                db.SectionSocialStudiesBigIdeas.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] {socialStudiesBigIdea}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SocialStudiesBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            GridSelectSocialStudiesBigIdeaDto socialStudiesBigIdea)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new SectionSocialStudiesBigIdea
                {
                    Id = socialStudiesBigIdea.Id,
                    BigIdeaForSocialStudiesId = socialStudiesBigIdea.BigIdeaForSocialStudiesId,
                    Context = socialStudiesBigIdea.Context,
                    SectionId = socialStudiesBigIdea.ParentId
                };
                // Attach the entity
                db.SectionSocialStudiesBigIdeas.Attach(entity);
                // Delete the entity
                db.SectionSocialStudiesBigIdeas.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] {socialStudiesBigIdea}.ToDataSourceResult(request, ModelState));
        }
    }
}