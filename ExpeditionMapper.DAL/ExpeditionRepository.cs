using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ExpeditionMapper.BE.Domain;

namespace ExpeditionMapper.DAL
{
    public class ExpeditionRepository : IExpeditionRepository
    {
        private ExpeditionContext db = new ExpeditionContext();

        public IEnumerable<Expedition> GetAll()
        {
            return db.Expeditions.ToList();
        }

        public Expedition Find(int? id)
        {
            return db.Expeditions.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                Expedition expedition = Find(id);
                db.Expeditions.Remove(expedition);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(Expedition expedition)
        {
            if (expedition.Id == default(int))
            {
                // New entity
                db.Expeditions.Add(expedition);
            }
            else
            {
                // Existing entity
                db.Entry(expedition).State = EntityState.Modified;
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