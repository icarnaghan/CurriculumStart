using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Mapper21.Business.Dto;
using Mapper21.Business.Interfaces;

namespace Mapper21.Site.Controllers
{
    public class HabitController : BaseController
    {
        private readonly IHabitManager _habitManager;

        public HabitController(IHabitManager habitManager)
        {
            _habitManager = habitManager;
        }

        public ActionResult Section_Habit_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> habits = _habitManager.GetSectionHabitList(sectionId);
            return Json(habits.ToDataSourceResult(request));
        }

        public ActionResult SubSection_Habit_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> habits = _habitManager.GetSubSectionHabitList(subSectionId);
            return Json(habits.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Section_Habit_Create([DataSourceRequest] DataSourceRequest request,
            GridDto habit)
        {
            if (ModelState.IsValid)
            {
                var newHabit = _habitManager.SaveOrUpdateSectionHabit(habit);

                habit.Id = newHabit.Id;
            }
            return Json(new[] {habit}.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SubSection_Habit_Create([DataSourceRequest] DataSourceRequest request,
            GridDto habit)
        {
            if (ModelState.IsValid)
            {
                var newHabit = _habitManager.SaveOrUpdateSubSectionHabit(habit);

                habit.Id = newHabit.Id;
            }
            return Json(new[] { habit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Section_Habit_Update([DataSourceRequest] DataSourceRequest request,
            GridDto updateHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.SaveOrUpdateSectionHabit(updateHabit);
            }
            return Json(new[] { updateHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_Habit_Update([DataSourceRequest] DataSourceRequest request,
            GridDto updateHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.SaveOrUpdateSubSectionHabit(updateHabit);
            }
            return Json(new[] { updateHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Section_Habit_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto deleteHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.DeleteSectionHabit(deleteHabit.Id);
            }
            return Json(new[] { deleteHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_Habit_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto deleteHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.DeleteSubSectionHabit(deleteHabit.Id);
            }
            return Json(new[] { deleteHabit }.ToDataSourceResult(request, ModelState));
        }
    }
}