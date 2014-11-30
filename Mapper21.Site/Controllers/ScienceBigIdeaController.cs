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
    public class ScienceBigIdeaController : BaseController
    {
        private readonly IScienceBigIdeaManager _scienceBigIdeaManager;

        public ScienceBigIdeaController(IScienceBigIdeaManager scienceBigIdeaManager)
        {
            _scienceBigIdeaManager = scienceBigIdeaManager;
        }

        public ActionResult ScienceBigIdea_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> scienceBigIdeas = _scienceBigIdeaManager.GetList(sectionId);
            return Json(scienceBigIdeas.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ScienceBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            GridDto scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                var newScienceBigIdea = _scienceBigIdeaManager.SaveOrUpdate(scienceBigIdea);

                scienceBigIdea.Id = newScienceBigIdea.Id;
            }
            return Json(new[] {scienceBigIdea}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ScienceBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            GridDto scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                _scienceBigIdeaManager.SaveOrUpdate(scienceBigIdea);
            }
            return Json(new[] { scienceBigIdea }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ScienceBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto scienceBigIdea)
        {
            if (ModelState.IsValid)
            {
                _scienceBigIdeaManager.Delete(scienceBigIdea.Id);
            }
            return Json(new[] { scienceBigIdea }.ToDataSourceResult(request, ModelState));
        }
    }
}