using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ILongTermTargetManager
    {
        GridDto FindSubSectionLongTermTarget(Guid id);
        GridDto SaveOrUpdateSubSectionLongTermTarget(GridDto x);
        bool DeleteSubSectionLongTermTarget(Guid id);
        void Dispose();
    }
}