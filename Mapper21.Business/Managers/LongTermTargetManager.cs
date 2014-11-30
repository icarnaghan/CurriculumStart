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
        readonly IGenericDataRepository<SubSectionLongTermTarget> _subSectionLongTermTargetRepo;

        public LongTermTargetManager(IGenericDataRepository<SubSectionLongTermTarget> subSectionLongTermTargetRepo)
        {
            this._subSectionLongTermTargetRepo = subSectionLongTermTargetRepo;
            AutoMapperConfig.Init();
        }

        public GridDto FindSubSectionLongTermTarget(Guid id)
        {
            SubSectionLongTermTarget longTermTarget = _subSectionLongTermTargetRepo.GetSingle(x => x.SubSectionStaId == id);
            return Mapper.Map<GridDto>(longTermTarget);
        }

        public GridDto SaveOrUpdateSubSectionLongTermTarget(GridDto x)
        {
            SubSectionLongTermTarget p = Mapper.Map<SubSectionLongTermTarget>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionLongTermTargetRepo.Add(p);
                }
                else
                {
                    _subSectionLongTermTargetRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSubSectionLongTermTarget(Guid id)
        {
            try
            {
                GridDto longTermTarget = FindSubSectionLongTermTarget(id);
                SubSectionLongTermTarget p = Mapper.Map<SubSectionLongTermTarget>(longTermTarget);
                _subSectionLongTermTargetRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionLongTermTargetRepo.Dispose();
        }
    }
}