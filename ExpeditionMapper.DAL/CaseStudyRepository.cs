using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ExpeditionMapper.BE.Domain;

namespace ExpeditionMapper.DAL
{
    public class CaseStudyRepository : ICaseStudyRepository
    {
        private ExpeditionContext db = new ExpeditionContext();

        public IEnumerable<CaseStudy> GetAll()
        {
            return db.CaseStudies.ToList();
        }

        public IEnumerable<CaseStudy> GetAllByExpedition(int? id)
        {
            return db.CaseStudies.ToList();
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