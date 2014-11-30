using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IOtherBigIdeaManager
    {
        IList<GridDto> GetSectionOtherBigIdeaList(Guid Id);
        IList<GridDto> GetSubSectionOtherBigIdeaList(Guid Id);
        GridDto FindSectionOtherBigIdea(Guid id);
        GridDto FindSubSectionOtherBigIdea(Guid id);
        GridDto SaveOrUpdateSectionOtherBigIdea(GridDto x);
        GridDto SaveOrUpdateSubSectionOtherBigIdea(GridDto x);
        bool DeleteSectionOtherBigIdea(Guid id);
        bool DeleteSubSectionOtherBigIdea(Guid id);
        void Dispose();
    }
}