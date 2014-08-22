using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ISubSectionLongTermTargetRepository : IDisposable
    {
        IEnumerable<SubSectionLongTermTarget> GetAll();
        void InsertorUpdate(SubSectionLongTermTarget subSectionLongTermTarget);
        SubSectionLongTermTarget Find(Guid id);
        bool Delete(Guid id);
        void Save();
    }
}