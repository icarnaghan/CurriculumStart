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
    public class StandardManager : IStandardManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionStandard> _subSectionStandardRepo;

        public StandardManager(IGenericDataRepository<SubSectionStandard> subSectionStandardRepo)
        {
            this._subSectionStandardRepo = subSectionStandardRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSubSectionStandardList(Guid id)
        {
            IList<SubSectionStandard> _list;
            _list = _subSectionStandardRepo.GetList(s => s.SubSectionStaId == id).ToList<SubSectionStandard>();
            return Mapper.Map<IList<SubSectionStandard>, IList<GridDto>>(_list);
        }

        public GridDto FindSubSectionStandard(Guid id)
        {
            SubSectionStandard standard = _subSectionStandardRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(standard);
        }

        public GridDto SaveOrUpdateSubSectionStandard(GridDto x)
        {
            SubSectionStandard p = Mapper.Map<SubSectionStandard>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionStandardRepo.Add(p);
                }
                else
                {
                    _subSectionStandardRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSubSectionStandard(Guid id)
        {
            try
            {
                GridDto standard = FindSubSectionStandard(id);
                SubSectionStandard p = Mapper.Map<SubSectionStandard>(standard);
                _subSectionStandardRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionStandardRepo.Dispose();
        }
    }
}