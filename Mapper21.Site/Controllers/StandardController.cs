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
    public class StandardController : BaseController
    {
        private readonly IStandardManager _standardManager;

        public StandardController(IStandardManager standardManager)
        {
            _standardManager = standardManager;
        }

        public ActionResult Standard_Read(Guid subSectionStaId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> standard = _standardManager.GetList(subSectionStaId);
            return Json(standard.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Standard_Create([DataSourceRequest] DataSourceRequest request, GridDto standard)
        {
            if (ModelState.IsValid)
            {
                var newStandard = _standardManager.SaveOrUpdate(standard);

                standard.Id = newStandard.Id;
            }
            return Json(new[] { standard }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Standard_Update([DataSourceRequest] DataSourceRequest request, GridDto standard)
        {
            if (ModelState.IsValid)
            {
                _standardManager.SaveOrUpdate(standard);
            }
            return Json(new[] { standard }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Standard_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto standard)
        {
            if (ModelState.IsValid)
            {
                _standardManager.Delete(standard.Id);
            }
            return Json(new[] { standard }.ToDataSourceResult(request, ModelState));
        }
    }
}