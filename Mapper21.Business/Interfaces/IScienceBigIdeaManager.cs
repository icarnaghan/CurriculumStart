using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IScienceBigIdeaManager
    {
        IList<GridDto> GetSectionScienceBigIdeaList(Guid Id);
        GridDto FindSectionScienceBigIdea(Guid id);
        GridDto SaveOrUpdateSectionScienceBigIdea(GridDto section);
        bool DeleteSectionScienceBigIdea(Guid id);
        void Dispose();
    }
}