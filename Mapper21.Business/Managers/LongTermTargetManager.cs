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
    public class LongTermTargetManager : ILongTermTargetManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IGenericDataRepository<SubSectionLongTermTarget> _repo;

        //Initialize manager, inject repository instance and configure automapper
        public LongTermTargetManager(IGenericDataRepository<SubSectionLongTermTarget> repo)
        {
            this._repo = repo;
            AutoMapperConfig.Init();
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<LongTermTargetDto> GetAll()
        {
            IList<SubSectionLongTermTarget> _list;
            _list = _repo.GetAll().ToList<SubSectionLongTermTarget>();
            return Mapper.Map<IList<SubSectionLongTermTarget>, IList<LongTermTargetDto>>(_list);
        }

        //Could be split into two methods.  Based on the database paradigm, an ID will
        //only exist after the object has been atomically saved once and persisted
        public LongTermTargetDto SaveOrUpdate(LongTermTargetDto x)
        {
            SubSectionLongTermTarget p = Mapper.Map<SubSectionLongTermTarget>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _repo.Add(p);
                }
                else
                {
                    _repo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<LongTermTargetDto>(p);
        }

        public LongTermTargetDto Find(Guid id)
        {
            SubSectionLongTermTarget subSectionLongTermTarget = _repo.GetSingle(x => x.Id == id);
            return Mapper.Map<LongTermTargetDto>(subSectionLongTermTarget);
        }

        public bool Delete(Guid id)
        {
            try
            {
                LongTermTargetDto subSectionLongTermTarget = Find(id);
                SubSectionLongTermTarget p = Mapper.Map<SubSectionLongTermTarget>(subSectionLongTermTarget);
                _repo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}