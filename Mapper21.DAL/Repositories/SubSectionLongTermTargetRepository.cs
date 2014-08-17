using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
{
    public class SubSectionLongTermTargetRepository : ISubSectionLongTermTargetRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<SubSectionLongTermTarget> GetAll()
        {
            return db.SubSectionLongTermTargets.ToList();
        }

        public SubSectionLongTermTarget Find(int? id)
        {
            return db.SubSectionLongTermTargets.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                SubSectionLongTermTarget subSectionLongTermTarget = Find(id);
                db.SubSectionLongTermTargets.Remove(subSectionLongTermTarget);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(SubSectionLongTermTarget subSectionLongTermTarget)
        {
            if (subSectionLongTermTarget.Id == default(int))
            {
                // New entity
                db.SubSectionLongTermTargets.Add(subSectionLongTermTarget);
            }
            else
            {
                // Existing entity
                db.Entry(subSectionLongTermTarget).State = EntityState.Modified;
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