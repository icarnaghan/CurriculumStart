using System;
using System.Collections.Generic;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.DAL.Interfaces
{
    public interface ISectionRepository : IDisposable
    {
        IEnumerable<Section> GetAll();
        IEnumerable<Habit> GetHabits();
        IEnumerable<BigIdeaForScience> GetBigIdeaForSciences();
        IEnumerable<BigIdeaForSocialStudies> GetBigIdeaForSocialStudies();
        Section GetSectionByGrade(string id, string year);
        Section GetFirstSixWeeksByGrade(string id, string year);
        Section GetFallExpeditionByGrade(string id, string year);
        Section GetMiniMesterByGrade(string id, string year);
        Section GetSpringExpeditionByGrade(string id, string year);
        Section GetSubjectAreaByGrade(string id, string year, int subjectAreaId);
        void InsertorUpdate(Section section);
        Section Find(int? id);
        bool Delete(int id);
        void Save();
    }

}