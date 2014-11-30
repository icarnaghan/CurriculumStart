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
    public class ShortTermTargetController : BaseController
    {
        private readonly IShortTermTargetManager _shortTermTargetManager;

        public ShortTermTargetController(IShortTermTargetManager shortTermTargetManager)
        {
            _shortTermTargetManager = shortTermTargetManager;
        }

        public ActionResult ShortTermTarget_Read(Guid subSectionStaId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> shortTermTarget = _shortTermTargetManager.GetSubSectionShortTermTargetList(subSectionStaId);
            return Json(shortTermTarget.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ShortTermTarget_Create([DataSourceRequest] DataSourceRequest request, GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                var newShortTermTarget = _shortTermTargetManager.SaveOrUpdateSubSectionShortTermTarget(shortTermTarget);

                shortTermTarget.Id = newShortTermTarget.Id;
            }
            return Json(new[] { shortTermTarget }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ShortTermTarget_Update([DataSourceRequest] DataSourceRequest request, GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                _shortTermTargetManager.SaveOrUpdateSubSectionShortTermTarget(shortTermTarget);
            }
            return Json(new[] { shortTermTarget }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ShortTermTarget_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto shortTermTarget)
        {
            if (ModelState.IsValid)
            {
                _shortTermTargetManager.DeleteSubSectionShortTermTarget(shortTermTarget.Id);
            }
            return Json(new[] { shortTermTarget }.ToDataSourceResult(request, ModelState));
        }
    }
}