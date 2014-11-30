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
    public class AssessmentManager : IAssessmentManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SubSectionAssessment> _subSectionAssessmentRepo;

        public AssessmentManager(IGenericDataRepository<SubSectionAssessment> subSectionAssessmentRepo)
        {
            this._subSectionAssessmentRepo = subSectionAssessmentRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetList(Guid id)
        {
            IList<SubSectionAssessment> _list;
            _list = _subSectionAssessmentRepo.GetList(s => s.SubSectionStaId == id).ToList<SubSectionAssessment>();
            return Mapper.Map<IList<SubSectionAssessment>, IList<GridDto>>(_list);
        }

        public GridDto Find(Guid id)
        {
            SubSectionAssessment assessment = _subSectionAssessmentRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(assessment);
        }

        public GridDto SaveOrUpdate(GridDto x)
        {
            SubSectionAssessment p = Mapper.Map<SubSectionAssessment>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionAssessmentRepo.Add(p);
                }
                else
                {
                    _subSectionAssessmentRepo.Update(p);                 
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
                GridDto assessment = Find(id);
                SubSectionAssessment p = Mapper.Map<SubSectionAssessment>(assessment);
                _subSectionAssessmentRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _subSectionAssessmentRepo.Dispose();
        }
    }
}