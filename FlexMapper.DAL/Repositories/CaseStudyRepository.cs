﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
{
    public class CaseStudyRepository : ICaseStudyRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<CaseStudy> GetAll()
        {
            return db.CaseStudies.ToList();
        }

        public IEnumerable<CaseStudy> GetAllBySection(int? id)
        {
            return db.CaseStudies.ToList();
        }

        public IEnumerable<StaGrid> GetStaGrids(int? id)
        {
            return db.StaGrid.Where(s => s.CaseStudyId == id).ToList();
        }

        public CaseStudy Find(int? id)
        {
            return db.CaseStudies.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                CaseStudy caseStudy = Find(id);
                db.CaseStudies.Remove(caseStudy);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(CaseStudy caseStudy)
        {
            if (caseStudy.Id == default(int))
            {
                // New entity
                db.CaseStudies.Add(caseStudy);
            }
            else
            {
                // Existing entity
                db.Entry(caseStudy).State = EntityState.Modified;
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