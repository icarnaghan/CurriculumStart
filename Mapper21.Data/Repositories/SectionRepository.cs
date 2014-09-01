﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.Data.Interfaces;
using Mapper21.Data.Provider;
using Mapper21.Domain;

namespace Mapper21.Data.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<Section> GetAll()
        {
            return db.Sections.ToList();
        }

        public Section GetSection(string gradeLevel, string year, string sectionType)
        {
            int currentYear = int.Parse(year);
            return db.Sections.SingleOrDefault(s => s.GradeLevelId == gradeLevel && s.Year == currentYear && s.SectionTypeId == sectionType);
        }

        public Section Find(Guid id)
        {
            return db.Sections.Find(id);
        }

        public bool Delete(Guid id)
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
            if (section.Id == default(Guid))
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