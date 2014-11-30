using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IStandardManager
    {
        IList<GridDto> GetSubSectionStandardList(Guid Id);
        GridDto FindSubSectionStandard(Guid id);
        GridDto SaveOrUpdateSubSectionStandard(GridDto x);
        bool DeleteSubSectionStandard(Guid id);
        void Dispose();
    }
}