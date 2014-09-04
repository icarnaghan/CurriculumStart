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
    public class SubSectionManager : ISubSectionManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IGenericDataRepository<SubSection> _repo;

        //Initialize manager, inject repository instance and configure automapper
        public SubSectionManager(IGenericDataRepository<SubSection> repo)
        {
            this._repo = repo;
            AutoMapperConfig.Init();
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<SubSectionDto> GetAll()
        {
            IList<SubSection> _list;
            _list = _repo.GetAll().ToList<SubSection>();
            return Mapper.Map<IList<SubSection>, IList<SubSectionDto>>(_list);
        }

        public IList<SubSectionDto> GetAllBySection(Guid id)
        {
            IList <SubSection> _list;
            _list = _repo.GetAll(s => s.SectionId == id).ToList<SubSection>();
            return Mapper.Map<IList<SubSection>, IList<SubSectionDto>>(_list);
        }

        //Could be split into two methods.  Based on the database paradigm, an ID will
        //only exist after the object has been atomically saved once and persisted
        public SubSectionDto SaveOrUpdate(SubSectionDto x)
        {
            SubSection p = Mapper.Map<SubSection>(x);
            try
            {
                if (p.Id == default(Guid))
                {
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
            return Mapper.Map<SubSectionDto>(p);
        }

        public SubSectionDto Find(Guid id)
        {
            SubSection subSection = _repo.GetSingle(x => x.Id == id);
            return Mapper.Map<SubSectionDto>(subSection);
        }

        public bool Delete(Guid id)
        {
            try
            {
                SubSectionDto subSection = Find(id);
                SubSection p = Mapper.Map<SubSection>(subSection);
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