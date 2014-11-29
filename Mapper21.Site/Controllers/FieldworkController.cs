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
    public class FieldworkController : BaseController
    {
        private readonly IFieldworkManager _fieldworkManager;

        public FieldworkController(IFieldworkManager fieldworkManager)
        {
            _fieldworkManager = fieldworkManager;
        }

        public ActionResult Fieldwork_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> fieldwork = _fieldworkManager.GetSubSectionFieldworkList(subSectionId);
            return Json(fieldwork.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Fieldwork_Create([DataSourceRequest] DataSourceRequest request, GridDto fieldwork)
        {
            if (ModelState.IsValid)
            {
                var newFieldwork = _fieldworkManager.SaveOrUpdateSubSectionFieldwork(fieldwork);

                fieldwork.Id = newFieldwork.Id;
            }
            return Json(new[] { fieldwork }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Fieldwork_Update([DataSourceRequest] DataSourceRequest request, GridDto fieldwork)
        {
            if (ModelState.IsValid)
            {
                _fieldworkManager.SaveOrUpdateSubSectionFieldwork(fieldwork);
            }
            return Json(new[] { fieldwork }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Fieldwork_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto fieldwork)
        {
            if (ModelState.IsValid)
            {
                _fieldworkManager.DeleteSubSectionFieldwork(fieldwork.Id);
            }
            return Json(new[] { fieldwork }.ToDataSourceResult(request, ModelState));
        }
    }
}