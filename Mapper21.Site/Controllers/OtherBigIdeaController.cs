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
    public class OtherBigIdeaController : BaseController
    {
        private readonly IOtherBigIdeaManager _otherBigIdeaManager;

        public OtherBigIdeaController(IOtherBigIdeaManager otherBigIdeaManager)
        {
            _otherBigIdeaManager = otherBigIdeaManager;
        }

        public ActionResult Section_OtherBigIdea_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> otherBigIdeas = _otherBigIdeaManager.GetSectionOtherBigIdeaList(sectionId);
            return Json(otherBigIdeas.ToDataSourceResult(request));
        }

        public ActionResult SubSection_OtherBigIdea_Read(Guid subSectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> otherBigIdeas = _otherBigIdeaManager.GetSubSectionOtherBigIdeaList(subSectionId);
            return Json(otherBigIdeas.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Section_OtherBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                var newOtherBigIdea = _otherBigIdeaManager.SaveOrUpdateSectionOtherBigIdea(otherBigIdea);

                otherBigIdea.Id = newOtherBigIdea.Id;
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));

        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SubSection_OtherBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                var newOtherBigIdea = _otherBigIdeaManager.SaveOrUpdateSubSectionOtherBigIdea(otherBigIdea);

                otherBigIdea.Id = newOtherBigIdea.Id;
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));

        }

        public ActionResult Section_OtherBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                _otherBigIdeaManager.SaveOrUpdateSectionOtherBigIdea(otherBigIdea);
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_OtherBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                _otherBigIdeaManager.SaveOrUpdateSubSectionOtherBigIdea(otherBigIdea);
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Section_OtherBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                _otherBigIdeaManager.DeleteSectionOtherBigIdea(otherBigIdea.Id);
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SubSection_OtherBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto otherBigIdea)
        {
            if (ModelState.IsValid)
            {
                _otherBigIdeaManager.DeleteSubSectionOtherBigIdea(otherBigIdea.Id);
            }
            return Json(new[] { otherBigIdea }.ToDataSourceResult(request, ModelState));
        }
    }
}