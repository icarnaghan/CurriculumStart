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
    public class ShortTermTargetManager : IShortTermTargetManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionShortTermTarget> _subSectionShortTermTargetRepo;

        public ShortTermTargetManager(IGenericDataRepository<SubSectionShortTermTarget> subSectionShortTermTargetRepo)
        {
            this._subSectionShortTermTargetRepo = subSectionShortTermTargetRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetList(Guid id)
        {
            IList<SubSectionShortTermTarget> _list;
            _list = _subSectionShortTermTargetRepo.GetList(s => s.SubSectionStaId == id).ToList<SubSectionShortTermTarget>();
            return Mapper.Map<IList<SubSectionShortTermTarget>, IList<GridDto>>(_list);
        }

        public GridDto Find(Guid id)
        {
            SubSectionShortTermTarget shortTermTarget = _subSectionShortTermTargetRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(shortTermTarget);
        }

        public GridDto SaveOrUpdate(GridDto x)
        {
            SubSectionShortTermTarget p = Mapper.Map<SubSectionShortTermTarget>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionShortTermTargetRepo.Add(p);
                }
                else
                {
                    _subSectionShortTermTargetRepo.Update(p);                 
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
                GridDto shortTermTarget = Find(id);
                SubSectionShortTermTarget p = Mapper.Map<SubSectionShortTermTarget>(shortTermTarget);
                _subSectionShortTermTargetRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionShortTermTargetRepo.Dispose();
        }
    }
}