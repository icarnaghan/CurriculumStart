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
    public class ServiceLearningController : BaseController
    {
        private readonly IServiceLearningManager _serviceLearningManager;

        public ServiceLearningController(IServiceLearningManager serviceLearningManager)
        {
            _serviceLearningManager = serviceLearningManager;
        }

        public ActionResult ServiceLearning_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> serviceLearning = _serviceLearningManager.GetSubSectionServiceLearningList(subSectionId);
            return Json(serviceLearning.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ServiceLearning_Create([DataSourceRequest] DataSourceRequest request, GridDto serviceLearning)
        {
            if (ModelState.IsValid)
            {
                var newServiceLearning = _serviceLearningManager.SaveOrUpdateSubSectionServiceLearning(serviceLearning);

                serviceLearning.Id = newServiceLearning.Id;
            }
            return Json(new[] { serviceLearning }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ServiceLearning_Update([DataSourceRequest] DataSourceRequest request, GridDto serviceLearning)
        {
            if (ModelState.IsValid)
            {
                _serviceLearningManager.SaveOrUpdateSubSectionServiceLearning(serviceLearning);
            }
            return Json(new[] { serviceLearning }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ServiceLearning_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto serviceLearning)
        {
            if (ModelState.IsValid)
            {
                _serviceLearningManager.DeleteSubSectionServiceLearning(serviceLearning.Id);
            }
            return Json(new[] { serviceLearning }.ToDataSourceResult(request, ModelState));
        }
    }
}