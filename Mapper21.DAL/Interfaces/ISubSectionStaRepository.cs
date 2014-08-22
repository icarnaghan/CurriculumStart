using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ISubSectionStaRepository : IDisposable
    {
        void InsertorUpdate(SubSectionSta subSectionSta);
        SubSectionSta Find(Guid id);
        bool Delete(Guid id);
        void Save();
    }
}