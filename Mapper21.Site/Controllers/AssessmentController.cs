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
    public class AssessmentController : BaseController
    {
        private readonly IAssessmentManager _assessmentManager;

        public AssessmentController(IAssessmentManager assessmentManager)
        {
            _assessmentManager = assessmentManager;
        }

        public ActionResult Assessment_Read(Guid subSectionStaId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> assessment = _assessmentManager.GetList(subSectionStaId);
            return Json(assessment.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Assessment_Create([DataSourceRequest] DataSourceRequest request, GridDto assessment)
        {
            if (ModelState.IsValid)
            {
                var newAssessment = _assessmentManager.SaveOrUpdate(assessment);

                assessment.Id = newAssessment.Id;
            }
            return Json(new[] { assessment }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Assessment_Update([DataSourceRequest] DataSourceRequest request, GridDto assessment)
        {
            if (ModelState.IsValid)
            {
                _assessmentManager.SaveOrUpdate(assessment);
            }
            return Json(new[] { assessment }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Assessment_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto assessment)
        {
            if (ModelState.IsValid)
            {
                _assessmentManager.Delete(assessment.Id);
            }
            return Json(new[] { assessment }.ToDataSourceResult(request, ModelState));
        }
    }
}