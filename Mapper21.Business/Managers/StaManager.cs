using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using log4net;
using Mapper21.Business.Dto;
using Mapper21.Business.Interfaces;
using Mapper21.Data.Interfaces;
using Mapper21.Domain;

namespace Mapper21.Business.Managers
{
    public class StaManager : IStaManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionStaGrid> _staGridRepo;
        readonly IGenericDataRepository<SubSectionSta> _staRepo;

        //Initialize manager, inject repository instance and configure automapper
        public StaManager(IGenericDataRepository<SubSectionStaGrid> staGridRepo,
                              IGenericDataRepository<SubSectionSta> staRepo)
        {
            this._staGridRepo = staGridRepo;
            this._staRepo = staRepo;
            AutoMapperConfig.Init();
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<StaGridDto> GetStaGrids(Guid id)
        {
            IList<SubSectionStaGrid> _list;
            _list = _staGridRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionStaGrid>();
            return Mapper.Map<IList<SubSectionStaGrid>, IList<StaGridDto>>(_list);
        }

        //Could be split into two methods.  Based on the database paradigm, an ID will
        //only exist after the object has been atomically saved once and persisted
        public SubSectionStaDto SaveOrUpdate(SubSectionStaDto x)
        {
            SubSectionSta p = Mapper.Map<SubSectionSta>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _staRepo.Add(p);
                }
                else
                {
                    _staRepo.Update(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<SubSectionStaDto>(p);
        }

        public SubSectionStaDto Find(Guid id)
        {
            SubSectionSta section = _staRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<SubSectionStaDto>(section);
        }

        public bool Delete(Guid id)
        {
            try
            {
                SubSectionStaDto section = Find(id);
                SubSectionSta p = Mapper.Map<SubSectionSta>(section);
                _staRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _staGridRepo.Dispose();
            _staRepo.Dispose();
        }
    }
}