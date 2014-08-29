using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.Data.Interfaces;
using Mapper21.Data.Provider;
using Mapper21.Domain;

namespace Mapper21.Data.Repositories
{
    public class SubSectionLongTermTargetRepository : ISubSectionLongTermTargetRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<SubSectionLongTermTarget> GetAll()
        {
            return db.SubSectionLongTermTargets.ToList();
        }

        public SubSectionLongTermTarget Find(Guid id)
        {
            return db.SubSectionLongTermTargets.Find(id);
        }

        public bool Delete(Guid id)
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
            if (subSectionLongTermTarget.Id == default(Guid))
            {
                // New entity
                subSectionLongTermTarget.Id = Guid.NewGuid();
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