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
        GridDto SaveOrUpdateSectionGuidingQuestion(GridDto x);
        GridDto SaveOrUpdateSubSectionGuidingQuestion(GridDto x);
        bool DeleteSectionGuidingQuestion(Guid id);
        bool DeleteSubSectionGuidingQuestion(Guid id);
        void Dispose();
    }
}