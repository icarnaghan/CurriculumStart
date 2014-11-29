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
    public class ExpertManager : IExpertManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionExpert> _subSectionExpertRepo;

        public ExpertManager(IGenericDataRepository<SubSectionExpert> subSectionExpertRepo)
        {
            this._subSectionExpertRepo = subSectionExpertRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSubSectionExpertList(Guid id)
        {
            IList<SubSectionExpert> _list;
            _list = _subSectionExpertRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionExpert>();
            return Mapper.Map<IList<SubSectionExpert>, IList<GridDto>>(_list);
        }

        public GridDto FindSubSectionExpert(Guid id)
        {
            SubSectionExpert expert = _subSectionExpertRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(expert);
        }

        public GridDto SaveOrUpdateSubSectionExpert(GridDto x)
        {
            SubSectionExpert p = Mapper.Map<SubSectionExpert>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionExpertRepo.Add(p);
                }
                else
                {
                    _subSectionExpertRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSubSectionExpert(Guid id)
        {
            try
            {
                GridDto expert = FindSubSectionExpert(id);
                SubSectionExpert p = Mapper.Map<SubSectionExpert>(expert);
                _subSectionExpertRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionExpertRepo.Dispose();
        }
    }
}