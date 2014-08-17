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
    public class SubSectionHabitController : BaseController
    {
        private readonly Mapper21Context db = new Mapper21Context();

        public ActionResult Habit_Read(int subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<SubSectionHabit> habits = db.SubSectionHabits.Where(h => h.SubSectionId == subSectionId);
            return Json(habits.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Habit_Create([DataSourceRequest] DataSourceRequest request,
            HabitSubSectionViewModel habit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Section entity and set its properties from the posted Section Model
                var entity = new SubSectionHabit
                {
                    Id = habit.Id,
                    HabitId = habit.HabitId,
                    Context = habit.Context,
                    SubSectionId = habit.SubSectionId
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
            HabitSubSectionViewModel updateHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted Section Model
                var entity = new SubSectionHabit
                {
                    Id = updateHabit.Id,
                    HabitId = updateHabit.HabitId,
                    Context = updateHabit.Context,
                    SubSectionId = updateHabit.SubSectionId
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
            HabitSubSectionViewModel deleteHabit)
        {
            if (ModelState.IsValid)
            {
                // Create a new Product entity and set its properties from the posted ProductViewModel
                var entity = new SubSectionHabit
                {
                    Id = deleteHabit.Id,
                    HabitId = deleteHabit.HabitId,
                    Context = deleteHabit.Context,
                    SubSectionId = deleteHabit.SubSectionId
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