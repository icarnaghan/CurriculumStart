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

        public ActionResult Habit_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridSelectHabitDto> habits = _habitManager.GetList(sectionId);
            return Json(habits.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Habit_Create([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto habit)
        {
            if (ModelState.IsValid)
            {
                var newHabit = _habitManager.SaveOrUpdate(habit);

                habit.Id = newHabit.Id;
            }
            return Json(new[] {habit}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Habit_Update([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto updateHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.SaveOrUpdate(updateHabit);
            }
            return Json(new[] { updateHabit }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Habit_Destroy([DataSourceRequest] DataSourceRequest request,
            GridSelectHabitDto deleteHabit)
        {
            if (ModelState.IsValid)
            {
                _habitManager.Delete(deleteHabit.Id);
            }
            return Json(new[] { deleteHabit }.ToDataSourceResult(request, ModelState));
        }
    }
}