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
    public class GuidingQuestionController : BaseController
    {
        private readonly IGuidingQuestionManager _guidingQuestionManager;

        public GuidingQuestionController(IGuidingQuestionManager guidingQuestionManager)
        {
            _guidingQuestionManager = guidingQuestionManager;
        }

        public ActionResult Section_GuidingQuestion_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> guidingQuestions = _guidingQuestionManager.GetSectionList(sectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        public ActionResult SubSection_GuidingQuestion_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> guidingQuestions = _guidingQuestionManager.GetSubSectionList(subSectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Section_GuidingQuestion_Create([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                var newGuidingQuestion = _guidingQuestionManager.SaveOrUpdateSection(guidingQuestion);

                guidingQuestion.Id = newGuidingQuestion.Id;
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SubSection_GuidingQuestion_Create([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                var newGuidingQuestion = _guidingQuestionManager.SaveOrUpdateSubSection(guidingQuestion);

                guidingQuestion.Id = newGuidingQuestion.Id;
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }


        public ActionResult Section_GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.SaveOrUpdateSection(guidingQuestion);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.SaveOrUpdateSubSection(guidingQuestion);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Section_GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.DeleteSection(guidingQuestion.Id);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.DeleteSubSection(guidingQuestion.Id);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }
    }
}