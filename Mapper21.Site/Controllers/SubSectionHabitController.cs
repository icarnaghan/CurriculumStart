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
    public class SubSectionHabitController : BaseController
    {
        private readonly Mapper21Context db = new Mapper21Context();

        public ActionResult Habit_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<SubSectionHabit> habits = db.SubSectionHabits.Where(h => h.SubSectionId == subSectionId);
            return Json(habits.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Habit_Create([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto habit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Section entity and set its properties from the posted Section Model
                var entity = new SubSectionHabit
                {
                    Id = Guid.NewGuid(),
                    HabitId = habit.HabitId,
                    Context = habit.Context,
                    SubSectionId = habit.ParentId
                };
                // Add the entity
                db.SubSectionHabits.Add(entity);
                // Insert the entities in the database
                db.SaveChanges();
                // Get the Id generated by the database
                habit.Id = entity.Id;
            }
            // Return the inserted entities. The grid needs the generated ID. Also return any validation errors.
            return Json(new[] {habit}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Habit_Update([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto updateHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted Section Model
                var entity = new SubSectionHabit
                {
                    Id = updateHabit.Id,
                    HabitId = updateHabit.HabitId,
                    Context = updateHabit.Context,
                    SubSectionId = updateHabit.ParentId
                };
                // Attach the entity
                db.SubSectionHabits.Attach(entity);
                // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one
                db.Entry(entity).State = EntityState.Modified;
                // Update the entity in the database
                db.SaveChanges();
            }
            // Return the updated entities. Also return any validation errors.
            return Json(new[] { updateHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Habit_Destroy([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto deleteHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new SubSectionHabit
                {
                    Id = deleteHabit.Id,
                    HabitId = deleteHabit.HabitId,
                    Context = deleteHabit.Context,
                    SubSectionId = deleteHabit.ParentId
                };
                // Attach the entity
                db.SubSectionHabits.Attach(entity);
                // Delete the entity
                db.SubSectionHabits.Remove(entity);
                // Delete the entity in the database
                db.SaveChanges();
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] { deleteHabit }.ToDataSourceResult(request, ModelState));
        }
    }
}