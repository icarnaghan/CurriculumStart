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
    public class FieldworkManager : IFieldworkManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionFieldwork> _subSectionFieldworkRepo;

        public FieldworkManager(IGenericDataRepository<SubSectionFieldwork> subSectionFieldworkRepo)
        {
            this._subSectionFieldworkRepo = subSectionFieldworkRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetList(Guid id)
        {
            IList<SubSectionFieldwork> _list;
            _list = _subSectionFieldworkRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionFieldwork>();
            return Mapper.Map<IList<SubSectionFieldwork>, IList<GridDto>>(_list);
        }

        public GridDto Find(Guid id)
        {
            SubSectionFieldwork fieldwork = _subSectionFieldworkRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(fieldwork);
        }

        public GridDto SaveOrUpdate(GridDto x)
        {
            SubSectionFieldwork p = Mapper.Map<SubSectionFieldwork>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionFieldworkRepo.Add(p);
                }
                else
                {
                    _subSectionFieldworkRepo.Update(p);                 
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
                GridDto fieldwork = Find(id);
                SubSectionFieldwork p = Mapper.Map<SubSectionFieldwork>(fieldwork);
                _subSectionFieldworkRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionFieldworkRepo.Dispose();
        }
    }
}