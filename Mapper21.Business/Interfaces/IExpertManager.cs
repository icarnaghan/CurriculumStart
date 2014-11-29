using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IExpertManager
    {
        IList<GridDto> GetSubSectionExpertList(Guid Id);
        GridDto FindSubSectionExpert(Guid id);
        GridDto SaveOrUpdateSubSectionExpert(GridDto subSection);
        bool DeleteSubSectionExpert(Guid id);
        void Dispose();
    }
}