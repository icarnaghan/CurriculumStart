using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpeditionMapper.DAL;
using ExpeditionMapper.Models;
using ExpeditionMapper.Models.Domain;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace ExpeditionMapper.Controllers
{
    public class EmployeeController : Controller
    {
        private ExpeditionContext db = new ExpeditionContext();
        
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees(int expeditionId, [DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<ExpeditionHabit> expeditionHabits = db.ExpeditionHabits.Where(h => h.ExpeditionId == expeditionId);
            return Json(expeditionHabits.ToDataSourceResult(request));
        }
    }
}