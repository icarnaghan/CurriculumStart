using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IGuidingQuestionManager
    {
        IList<GridDto> GetSectionList(Guid Id);
        IList<GridDto> GetSubSectionList(Guid Id);
        GridDto FindSection(Guid id);
        GridDto FindSubSection(Guid id);
        GridDto SaveOrUpdateSection(GridDto x);
        GridDto SaveOrUpdateSubSection(GridDto x);
        bool DeleteSection(Guid id);
        bool DeleteSubSection(Guid id);
        void Dispose();
    }
}