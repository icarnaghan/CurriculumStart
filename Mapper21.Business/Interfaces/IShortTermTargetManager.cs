using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IShortTermTargetManager
    {
        IList<GridDto> GetSubSectionShortTermTargetList(Guid Id);
        GridDto FindSubSectionShortTermTarget(Guid id);
        GridDto SaveOrUpdateSubSectionShortTermTarget(GridDto x);
        bool DeleteSubSectionShortTermTarget(Guid id);
        void Dispose();
    }
}