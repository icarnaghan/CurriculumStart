using System;
using Mapper21.Domain;

namespace Mapper21.Data.Interfaces
{
    public interface ISectionRepository : IDisposable
    {
        void InsertorUpdate(Section section);
        Section GetSection(string gradeLevel, string year, string sectionType);
        Section Find(Guid id);
        bool Delete(Guid id);
        void Save();
    }

}