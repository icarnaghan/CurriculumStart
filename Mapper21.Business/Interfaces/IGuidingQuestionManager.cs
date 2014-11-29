using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IGuidingQuestionManager
    {
        IList<GridDto> GetSectionGuidingQuestionList(Guid Id);
        IList<GridDto> GetSubSectionGuidingQuestionList(Guid Id);
        GridDto FindSectionGuidingQuestion(Guid id);
        GridDto FindSubSectionGuidingQuestion(Guid id);
        GridDto SaveOrUpdateSectionGuidingQuestion(GridDto section);
        GridDto SaveOrUpdateSubSectionGuidingQuestion(GridDto section);
        bool DeleteSectionGuidingQuestion(Guid id);
        bool DeleteSubSectionGuidingQuestion(Guid id);
        void Dispose();
    }
}