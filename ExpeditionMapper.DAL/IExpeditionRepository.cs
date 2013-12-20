using System;
using System.Collections.Generic;
using ExpeditionMapper.BE.Domain;

namespace ExpeditionMapper.DAL
{
    public interface IExpeditionRepository : IDisposable
    {
        IEnumerable<Expedition> GetAll();
        void InsertorUpdate(Expedition expedition);
        Expedition Find(int? id);
        bool Delete(int id);
        void Save();
    }

}