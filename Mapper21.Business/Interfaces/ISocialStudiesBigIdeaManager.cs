using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ISocialStudiesBigIdeaManager
    {
        IList<GridDto> GetSectionSocialStudiesBigIdeaList(Guid Id);
        GridDto FindSectionSocialStudiesBigIdea(Guid id);
        GridDto SaveOrUpdateSectionSocialStudiesBigIdea(GridDto x);
        bool DeleteSectionSocialStudiesBigIdea(Guid id);
        void Dispose();
    }
}