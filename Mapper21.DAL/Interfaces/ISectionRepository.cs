using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.DAL.Interfaces
{
    public interface ISectionRepository : IDisposable
    {
        IEnumerable<Section> GetAll();
        Section GetSectionByGrade(int id, string year);
        Section GetFirstSixWeeksByGrade(int id, string year);
        Section GetFallExpeditionByGrade(int id, string year);
        Section GetMiniMesterByGrade(int id, string year);
        Section GetSpringExpeditionByGrade(int id, string year);
        Section GetSubjectAreaByGrade(int id, string year, int subjectAreaId);
        void InsertorUpdate(Section section);
        Section Find(int? id);
        bool Delete(int id);
        void Save();
    }

}