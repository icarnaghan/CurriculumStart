using System;
using System.Collections.Generic;
using Mapper21.Domain;

namespace Mapper21.Data.Interfaces
{
    public interface ISubSectionRepository : IDisposable
    {
        IEnumerable<SubSection> GetAll();
        IEnumerable<SubSection> GetAllBySection(Guid id);
        IEnumerable<SubSectionStaGrid> GetStaGrids(Guid id);
        void InsertorUpdate(SubSection caseStudy);
        SubSection Find(Guid id);
        bool Delete(Guid id);
        void Save();
    }
}