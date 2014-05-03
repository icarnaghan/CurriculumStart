using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ICaseStudyRepository : IDisposable
    {
        IEnumerable<CaseStudy> GetAll();
        IEnumerable<CaseStudy> GetAllBySection(int? id);
        IEnumerable<StaGrid> GetStaGrids(int? id);
        void InsertorUpdate(CaseStudy caseStudy);
        CaseStudy Find(int? id);
        bool Delete(int id);
        void Save();
    }
}