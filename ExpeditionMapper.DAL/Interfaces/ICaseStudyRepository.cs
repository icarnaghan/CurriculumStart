﻿using System;
using System.Collections.Generic;
using ExpeditionMapper.BE.Domain;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.DAL.Interfaces
{
    public interface ICaseStudyRepository : IDisposable
    {
        IEnumerable<CaseStudy> GetAll();
        IEnumerable<CaseStudy> GetAllByExpedition(int? id);
        IEnumerable<StaGrid> GetStaGrids(int? id);
        void InsertorUpdate(CaseStudy caseStudy);
        CaseStudy Find(int? id);
        bool Delete(int id);
        void Save();
    }
}