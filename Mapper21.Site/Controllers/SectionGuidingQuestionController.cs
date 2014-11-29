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
    public class SectionGuidingQuestionController : BaseController
    {
        private readonly IGuidingQuestionManager _guidingQuestionManager;

        public SectionGuidingQuestionController(IGuidingQuestionManager guidingQuestionManager)
        {
            _guidingQuestionManager = guidingQuestionManager;
        }

        public ActionResult GuidingQuestion_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> guidingQuestions = _guidingQuestionManager.GetSectionGuidingQuestionList(sectionId);
            return Json(guidingQuestions.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult GuidingQuestion_Create([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                var newGuidingQuestion = _guidingQuestionManager.SaveOrUpdateSectionGuidingQuestion(guidingQuestion);

                guidingQuestion.Id = newGuidingQuestion.Id;
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult GuidingQuestion_Update([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.SaveOrUpdateSectionGuidingQuestion(guidingQuestion);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult GuidingQuestion_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto guidingQuestion)
        {
            if (ModelState.IsValid)
            {
                _guidingQuestionManager.DeleteSectionGuidingQuestion(guidingQuestion.Id);
            }
            return Json(new[] { guidingQuestion }.ToDataSourceResult(request, ModelState));
        }
    }
}