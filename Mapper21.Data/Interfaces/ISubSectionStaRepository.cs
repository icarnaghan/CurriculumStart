using System;
using Mapper21.Domain;

namespace Mapper21.Data.Interfaces
{
    public interface ISubSectionStaRepository : IDisposable
    {
        void InsertorUpdate(SubSectionSta subSectionSta);
        SubSectionSta Find(Guid id);
        bool Delete(Guid id);
        void Save();
    }
}