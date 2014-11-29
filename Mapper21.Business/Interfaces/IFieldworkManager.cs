using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IFieldworkManager
    {
        IList<GridDto> GetSubSectionFieldworkList(Guid Id);
        GridDto FindSubSectionFieldwork(Guid id);
        GridDto SaveOrUpdateSubSectionFieldwork(GridDto subSection);
        bool DeleteSubSectionFieldwork(Guid id);
        void Dispose();
    }
}