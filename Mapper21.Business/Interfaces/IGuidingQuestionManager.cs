using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IGuidingQuestionManager
    {
        IList<GridDto> GetSectionGuidingQuestionList(Guid Id);
        GridDto FindSectionGuidingQuestion(Guid id);
        GridDto SaveOrUpdateSectionGuidingQuestion(GridDto section);
        bool DeleteSectionGuidingQuestion(Guid id);
        void Dispose();
    }
}