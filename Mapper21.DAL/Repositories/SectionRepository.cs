using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<Section> GetAll()
        {
            return db.Sections.ToList();
        }

        public IEnumerable<Habit> GetHabits()
        {
            return db.Habits.ToList();
        }

        public Section GetSectionByGrade(string id, string year)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear);
        }

        public Section GetFirstSixWeeksByGrade(string id, string year)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear && s.SectionTypeId == 1);
        }

        public Section GetFallExpeditionByGrade(string id, string year)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear && s.SectionTypeId == 2);
        }

        public Section GetMiniMesterByGrade(string id, string year)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear && s.SectionTypeId == 3);
        }

        public Section GetSpringExpeditionByGrade(string id, string year)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear && s.SectionTypeId == 4);
        }

        public Section GetSubjectAreaByGrade(string id, string year, int subjectAreaId)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == id && s.Year == currentYear && s.SubjectAreaId == subjectAreaId);
        }


        public Section Find(int? id)
        {
            return db.Sections.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                Section section = Find(id);
                db.Sections.Remove(section);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(Section section)
        {
            if (section.Id == default(int))
            {
                // New entity
                db.Sections.Add(section);
            }
            else
            {
                // Existing entity
                db.Entry(section).State = EntityState.Modified;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}