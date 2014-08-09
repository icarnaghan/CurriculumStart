using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
{
    public class SubSectionRepository : ISubSectionRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<SubSection> GetAll()
        {
            return db.SubSections.ToList();
        }

        public IEnumerable<SubSection> GetAllBySection(int? id)
        {
            return db.SubSections.ToList();
        }

        public IEnumerable<SubSectionStaGrid> GetStaGrids(int? id)
        {
            return db.StaGrid.Where(s => s.CaseStudyId == id).ToList();
        }

        public SubSection Find(int? id)
        {
            return db.SubSections.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                SubSection caseStudy = Find(id);
                db.SubSections.Remove(caseStudy);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(SubSection subSection)
        {
            if (subSection.Id == default(int))
            {
                // New entity
                db.SubSections.Add(subSection);
            }
            else
            {
                // Existing entity
                db.Entry(subSection).State = EntityState.Modified;
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