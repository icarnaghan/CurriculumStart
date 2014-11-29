using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IAssessmentManager
    {
        IList<GridDto> GetSubSectionAssessmentList(Guid Id);
        GridDto FindSubSectionAssessment(Guid id);
        GridDto SaveOrUpdateSubSectionAssessment(GridDto subSection);
        bool DeleteSubSectionAssessment(Guid id);
        void Dispose();
    }
}