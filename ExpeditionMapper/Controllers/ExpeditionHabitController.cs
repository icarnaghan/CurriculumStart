﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.DAL;
using ExpeditionMapper.Models.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ExpeditionMapper.Controllers
{
    public class ExpeditionHabitController : BaseController
    {
        private ExpeditionContext db = new ExpeditionContext();

        public ActionResult ExpeditionHabit_Read(int expeditionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<ExpeditionHabit> expeditionHabits = db.ExpeditionHabits.Where(h => h.ExpeditionId == expeditionId);
            return Json(expeditionHabits.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExpeditionHabit_Create(int expeditionId, [DataSourceRequest]DataSourceRequest request, ExpeditionHabitViewModel expeditionHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Expedition entity and set its properties from the posted FallExpedition Model
                var entity = new ExpeditionHabit
                {
                    Id = expeditionHabit.Id,
                    Habit = expeditionHabit.Habit,
                    Rationale = expeditionHabit.Rationale,
                    ExpeditionId = 1
                };
                // Add the entity
                db.ExpeditionHabits.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                expeditionHabit.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] { expeditionHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Expeditionhabit_Update(int expeditionId, [DataSourceRequest]DataSourceRequest request, ExpeditionHabitViewModel expeditionHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ExpeditionViewModel
                var entity = new ExpeditionHabit
                {
                    Id = expeditionHabit.Id,
                    Habit = expeditionHabit.Habit,
                    Rationale = expeditionHabit.Rationale,
                    ExpeditionId = 1
                };
                // Attach the entity
                db.ExpeditionHabits.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] { expeditionHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ExpeditionHabig_Destroy(int expeditionId, [DataSourceRequest]DataSourceRequest request, ExpeditionHabitViewModel expeditionHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new ExpeditionHabit
                {
                    Id = expeditionHabit.Id,
                    Habit = expeditionHabit.Habit,
                    Rationale = expeditionHabit.Rationale,
                    ExpeditionId = 1
                };
                // Attach the entity
                db.ExpeditionHabits.Attach(entity);
                // Delete the entity
                db.ExpeditionHabits.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] { expeditionHabit }.ToDataSourceResult(request, ModelState));
        }
    }
}
