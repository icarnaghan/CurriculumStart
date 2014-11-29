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
    public class GuidingQuestionManager : IGuidingQuestionManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SectionGuidingQuestion> _sectionGuidingQuestionRepo;
        readonly IGenericDataRepository<SubSectionGuidingQuestion> _subSectionGuidingQuestionRepo;

        public GuidingQuestionManager(IGenericDataRepository<SectionGuidingQuestion> sectionGuidingQuestionRepo,
                                      IGenericDataRepository<SubSectionGuidingQuestion> subSectionGuidingQuestionRepo)
        {
            this._sectionGuidingQuestionRepo = sectionGuidingQuestionRepo;
            this._subSectionGuidingQuestionRepo = subSectionGuidingQuestionRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSectionGuidingQuestionList(Guid id)
        {
            IList<SectionGuidingQuestion> _list;
            _list = _sectionGuidingQuestionRepo.GetList(s => s.SectionId == id).ToList<SectionGuidingQuestion>();
            return Mapper.Map<IList<SectionGuidingQuestion>, IList<GridDto>>(_list);
        }

        public IList<GridDto> GetSubSectionGuidingQuestionList(Guid id)
        {
            IList<SubSectionGuidingQuestion> _list;
            _list = _subSectionGuidingQuestionRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionGuidingQuestion>();
            return Mapper.Map<IList<SubSectionGuidingQuestion>, IList<GridDto>>(_list);
        }

        public GridDto FindSectionGuidingQuestion(Guid id)
        {
            SectionGuidingQuestion guidingQuestion = _sectionGuidingQuestionRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(guidingQuestion);
        }

        public GridDto FindSubSectionGuidingQuestion(Guid id)
        {
            SubSectionGuidingQuestion guidingQuestion = _subSectionGuidingQuestionRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(guidingQuestion);
        }

        public GridDto SaveOrUpdateSectionGuidingQuestion(GridDto x)
        {
            SectionGuidingQuestion p = Mapper.Map<SectionGuidingQuestion>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _sectionGuidingQuestionRepo.Add(p);
                }
                else
                {
                    _sectionGuidingQuestionRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public GridDto SaveOrUpdateSubSectionGuidingQuestion(GridDto x)
        {
            SubSectionGuidingQuestion p = Mapper.Map<SubSectionGuidingQuestion>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionGuidingQuestionRepo.Add(p);
                }
                else
                {
                    _subSectionGuidingQuestionRepo.Update(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSectionGuidingQuestion(Guid id)
        {
            try
            {
                GridDto guidingQuestion = FindSectionGuidingQuestion(id);
                SectionGuidingQuestion p = Mapper.Map<SectionGuidingQuestion>(guidingQuestion);
                _sectionGuidingQuestionRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSubSectionGuidingQuestion(Guid id)
        {
            try
            {
                GridDto guidingQuestion = FindSectionGuidingQuestion(id);
                SubSectionGuidingQuestion p = Mapper.Map<SubSectionGuidingQuestion>(guidingQuestion);
                _subSectionGuidingQuestionRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _sectionGuidingQuestionRepo.Dispose();
            _subSectionGuidingQuestionRepo.Dispose();
        }
    }
}