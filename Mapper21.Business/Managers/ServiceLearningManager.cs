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
    public class ServiceLearningManager : IServiceLearningManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionServiceLearning> _subSectionServiceLearningRepo;

        public ServiceLearningManager(IGenericDataRepository<SubSectionServiceLearning> subSectionServiceLearningRepo)
        {
            this._subSectionServiceLearningRepo = subSectionServiceLearningRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetList(Guid id)
        {
            IList<SubSectionServiceLearning> _list;
            _list = _subSectionServiceLearningRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionServiceLearning>();
            return Mapper.Map<IList<SubSectionServiceLearning>, IList<GridDto>>(_list);
        }

        public GridDto Find(Guid id)
        {
            SubSectionServiceLearning serviceLearning = _subSectionServiceLearningRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(serviceLearning);
        }

        public GridDto SaveOrUpdate(GridDto x)
        {
            SubSectionServiceLearning p = Mapper.Map<SubSectionServiceLearning>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionServiceLearningRepo.Add(p);
                }
                else
                {
                    _subSectionServiceLearningRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool Delete(Guid id)
        {
            try
            {
                GridDto serviceLearning = Find(id);
                SubSectionServiceLearning p = Mapper.Map<SubSectionServiceLearning>(serviceLearning);
                _subSectionServiceLearningRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionServiceLearningRepo.Dispose();
        }
    }
}