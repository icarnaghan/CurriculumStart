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
    public class SocialStudiesBigIdeaController : BaseController
    {
        private readonly ISocialStudiesBigIdeaManager _socialStudiesBigIdeaManager;

        public SocialStudiesBigIdeaController(ISocialStudiesBigIdeaManager socialStudiesBigIdeaManager)
        {
            _socialStudiesBigIdeaManager = socialStudiesBigIdeaManager;
        }

        public ActionResult SocialStudiesBigIdea_Read(Guid sectionId, [DataSourceRequest] DataSourceRequest request)
        {
            IList<GridDto> socialStudiesBigIdeas = _socialStudiesBigIdeaManager.GetList(sectionId);
            return Json(socialStudiesBigIdeas.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SocialStudiesBigIdea_Create([DataSourceRequest] DataSourceRequest request,
            GridDto socialStudiesBigIdea)
        {
            if (ModelState.IsValid)
            {
                var newScienceBigIdea = _socialStudiesBigIdeaManager.SaveOrUpdate(socialStudiesBigIdea);

                socialStudiesBigIdea.Id = newScienceBigIdea.Id;
            }
            return Json(new[] { socialStudiesBigIdea }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SocialStudiesBigIdea_Update([DataSourceRequest] DataSourceRequest request,
            GridDto socialStudiesBigIdea)
        {
            {
                if (ModelState.IsValid)
                {
                    _socialStudiesBigIdeaManager.SaveOrUpdate(socialStudiesBigIdea);
                }
                return Json(new[] { socialStudiesBigIdea }.ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult SocialStudiesBigIdea_Destroy([DataSourceRequest] DataSourceRequest request,
            GridDto socialStudiesBigIdea)
        {
            if (ModelState.IsValid)
                if (ModelState.IsValid)
                {
                    _socialStudiesBigIdeaManager.Delete(socialStudiesBigIdea.Id);
                }
            return Json(new[] { socialStudiesBigIdea }.ToDataSourceResult(request, ModelState));
        }
    }
}