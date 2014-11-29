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
            IList<GridDto> guidingQuestions = _guidingQuestionManager.GetSectionGuidingQuestionList(sectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        public ActionResult SubSection_GuidingQuestion_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> guidingQuestions = _guidingQuestionManager.GetSubSectionGuidingQuestionList(subSectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Section_GuidingQuestion_Create([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                var newGuidingQuestion = _guidingQuestionManager.SaveOrUpdateSectionGuidingQuestion(guidingQuestion);

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
                var newGuidingQuestion = _guidingQuestionManager.SaveOrUpdateSubSectionGuidingQuestion(guidingQuestion);

                guidingQuestion.Id = newGuidingQuestion.Id;
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }


        public ActionResult Section_GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.SaveOrUpdateSectionGuidingQuestion(guidingQuestion);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.SaveOrUpdateSubSectionGuidingQuestion(guidingQuestion);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Section_GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.DeleteSectionGuidingQuestion(guidingQuestion.Id);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.DeleteSubSectionGuidingQuestion(guidingQuestion.Id);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }
    }
}