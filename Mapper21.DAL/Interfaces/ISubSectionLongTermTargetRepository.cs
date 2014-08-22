using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ISubSectionLongTermTargetRepository : IDisposable
    {
        IEnumerable<SubSectionLongTermTarget> GetAll();
        void InsertorUpdate(SubSectionLongTermTarget subSectionLongTermTarget);
        SubSectionLongTermTarget Find(int? id);
        bool Delete(int id);
        void Save();
    }
}