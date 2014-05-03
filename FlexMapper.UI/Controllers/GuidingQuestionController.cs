﻿using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Mapper21.BE.Domain;
using Mapper21.DAL.Provider;
using Mapper21.UI.Models;

namespace Mapper21.UI.Controllers
{
    public class GuidingQuestionController : BaseController
    {
        private readonly Mapper21Context db = new Mapper21Context();

        public ActionResult GuidingQuestion_Read(int sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<GuidingQuestion> guidingQuestions = db.GuidingQuestions.Where(g => g.SectionId == sectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult GuidingQuestion_Create(int sectionId, [DataSourceRequest] DataSourceRequest request,
            GuidingQuestionViewModel guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                // Create a new Section entity and set its properties from the posted Section Model
                var entity = new GuidingQuestion
                {
                    Id = guidingQuestion.Id,
                    Name = guidingQuestion.Name,
                    SectionId = guidingQuestion.SectionId
                };
                // Add the entity
                db.GuidingQuestions.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                guidingQuestion.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {guidingQuestion}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GuidingQuestionViewModel guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted Section Model
                var entity = new GuidingQuestion
                {
                    Id = guidingQuestion.Id,
                    Name = guidingQuestion.Name,
                    SectionId = guidingQuestion.SectionId
                };
                // Attach the entity
                db.GuidingQuestions.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] {guidingQuestion}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GuidingQuestionViewModel guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new GuidingQuestion
                {
                    Id = guidingQuestion.Id,
                    Name = guidingQuestion.Name,
                    SectionId = guidingQuestion.SectionId
                };
                // Attach the entity
                db.GuidingQuestions.Attach(entity);
                // Delete the entity
                db.GuidingQuestions.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] {guidingQuestion}.ToDataSourceResult(request, ModelState));
        }
    }
}