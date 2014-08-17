﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mapper21.BE.Domain;
using Mapper21.DAL.Interfaces;
using Mapper21.DAL.Provider;

namespace Mapper21.DAL.Repositories
{
    public class SubSectionStaRepository : ISubSectionStaRepository
    {
        private Mapper21Context db = new Mapper21Context();

        public IEnumerable<SubSectionSta> GetAll()
        {
            return db.SubSectionStas.ToList();
        }

        public SubSectionSta Find(int? id)
        {
            return db.SubSectionStas.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                SubSectionSta subSectionSta = Find(id);
                db.SubSectionStas.Remove(subSectionSta);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertorUpdate(SubSectionSta subSectionSta)
        {
            if (subSectionSta.Id == default(int))
            {
                // New entity
                db.SubSectionStas.Add(subSectionSta);
            }
            else
            {
                // Existing entity
                db.Entry(subSectionSta).State = EntityState.Modified;
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