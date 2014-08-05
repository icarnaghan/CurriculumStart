using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ICaseStudyRepository : IDisposable
    {
        IEnumerable<SubSection> GetAll();
        IEnumerable<SubSection> GetAllBySection(int? id);
        IEnumerable<StaGrid> GetStaGrids(int? id);
        void InsertorUpdate(SubSection caseStudy);
        SubSection Find(int? id);
        bool Delete(int id);
        void Save();
    }
}