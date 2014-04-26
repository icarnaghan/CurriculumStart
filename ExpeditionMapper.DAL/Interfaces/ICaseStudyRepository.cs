using System;
using System.Collections.Generic;
using FlexMapper.BE.Domain;

namespace FlexMapper.DAL.Interfaces
{
    public interface ICaseStudyRepository : IDisposable
    {
        IEnumerable<CaseStudy> GetAll();
        IEnumerable<CaseStudy> GetAllByExpedition(int? id);
        IEnumerable<StaGrid> GetStaGrids(int? id);
        void InsertorUpdate(CaseStudy caseStudy);
        CaseStudy Find(int? id);
        bool Delete(int id);
        void Save();
    }
}