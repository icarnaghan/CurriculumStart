using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface ISectionManager
    {
        IList<SectionDto> GetAll();
        SectionDto Find(Guid id);
        SectionDto GetSection(string gradeLevel, string year, string sectionType);
        SectionDto SaveOrUpdate(SectionDto section);
        bool Delete(Guid id);
        void Dispose();
    }
}