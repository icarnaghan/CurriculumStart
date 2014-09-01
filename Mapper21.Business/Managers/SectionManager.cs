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
    public class SectionManager : ISectionManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        IGenericDataRepository<Section> _repo;

        //Initialize manager, inject repository instance and configure automapper
        public SectionManager(IGenericDataRepository<Section> repo)
        {
            this._repo = repo;
            AutoMapperConfig.Init();
        }

        //Return a list of objects.  Intentional return of IList vs. IQueryable to 
        //more cleanly keep application layers clean.  
        //Developer may apply Linq Expressions as parameters to "GetAll" method to return child objects
        //or filter results to a subset of the list
        public IList<SectionDto> GetAll()
        {
            IList<Section> _list;
            _list = _repo.GetAll().ToList<Section>();
            return Mapper.Map<IList<Section>, IList<SectionDto>>(_list);
        }

        public SectionDto GetSection(string gradeLevel, string year, string sectionType)
        {
            int currentYear = int.Parse(year);
            Section section = _repo.GetSingle(s => s.GradeLevelId == gradeLevel && s.Year == currentYear && s.SectionTypeId == sectionType);
            return Mapper.Map<SectionDto>(section);
        }

        //Could be split into two methods.  Based on the database paradigm, an ID will
        //only exist after the object has been atomically saved once and persisted
        public SectionDto SaveOrUpdate(SectionDto x)
        {
            Section p = Mapper.Map<Section>(x);
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
            return Mapper.Map<SectionDto>(p);
        }

        public SectionDto Find(Guid id)
        {
            Section section = _repo.GetSingle(x => x.Id == id);
            return Mapper.Map<SectionDto>(section);
        }

        public bool Delete(Guid id)
        {
            try
            {
                SectionDto section = Find(id);
                Section p = Mapper.Map<Section>(section);
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