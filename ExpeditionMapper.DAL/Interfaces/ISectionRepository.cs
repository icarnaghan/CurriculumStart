using System;
using System.Collections.Generic;
using FlexMapper.BE.Domain;

namespace FlexMapper.DAL.Interfaces
{
    public interface ISectionRepository : IDisposable
    {
        IEnumerable<Section> GetAll();
        void InsertorUpdate(Section expedition);
        Section Find(int? id);
        bool Delete(int id);
        void Save();
    }

}