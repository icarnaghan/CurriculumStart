using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Mapper21.Business.Dto;
using Mapper21.Business.Interfaces;
using System.Collections.Generic;

namespace Mapper21.Site.Controllers
{
    public class ExpertController : BaseController
    {
        private readonly IExpertManager _expertManager;

        public ExpertController(IExpertManager expertManager)
        {
            _expertManager = expertManager;
        }

        public ActionResult Expert_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> expert = _expertManager.GetList(subSectionId);
            return Json(expert.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Expert_Create([DataSourceRequest] DataSourceRequest request, GridDto expert)
        {
            if (ModelState.IsValid)
            {
                var newExpert = _expertManager.SaveOrUpdate(expert);

                expert.Id = newExpert.Id;
            }
            return Json(new[] { expert }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Expert_Update([DataSourceRequest] DataSourceRequest request, GridDto expert)
        {
            if (ModelState.IsValid)
            {
                _expertManager.SaveOrUpdate(expert);
            }
            return Json(new[] { expert }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Expert_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto expert)
        {
            if (ModelState.IsValid)
            {
                _expertManager.Delete(expert.Id);
            }
            return Json(new[] { expert }.ToDataSourceResult(request, ModelState));
        }
    }
}