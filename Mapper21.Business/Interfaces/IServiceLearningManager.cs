using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IServiceLearningManager
    {
        IList<GridDto> GetSubSectionServiceLearningList(Guid Id);
        GridDto FindSubSectionServiceLearning(Guid id);
        GridDto SaveOrUpdateSubSectionServiceLearning(GridDto x);
        bool DeleteSubSectionServiceLearning(Guid id);
        void Dispose();
    }
}