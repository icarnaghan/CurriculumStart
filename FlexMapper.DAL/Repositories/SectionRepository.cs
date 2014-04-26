using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FlexMapper.BE.Domain;
using FlexMapper.DAL.Interfaces;
using FlexMapper.DAL.Provider;

namespace FlexMapper.DAL.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private FlexMapperContext db = new FlexMapperContext();

        public IEnumerable<Section> GetAll()
        {
            return db.Expeditions.ToList();
        }

        public Section Find(int? id)
        {
            return db.Expeditions.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                Section expedition = Find(id);
                db.Expeditions.Remove(expedition);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(Section expedition)
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