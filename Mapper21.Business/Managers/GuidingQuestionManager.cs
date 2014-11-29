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

        public GuidingQuestionManager(IGenericDataRepository<SectionGuidingQuestion> sectionGuidingQuestionRepo)
        {
            this._sectionGuidingQuestionRepo = sectionGuidingQuestionRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSectionGuidingQuestionList(Guid id)
        {
            IList<SectionGuidingQuestion> _list;
            _list = _sectionGuidingQuestionRepo.GetList(s => s.SectionId == id).ToList<SectionGuidingQuestion>();
            return Mapper.Map<IList<SectionGuidingQuestion>, IList<GridDto>>(_list);
        }

        public GridDto FindSectionGuidingQuestion(Guid id)
        {
            SectionGuidingQuestion guidingQuestion = _sectionGuidingQuestionRepo.GetSingle(x => x.Id == id);
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

        public void Dispose()
        {
            _sectionGuidingQuestionRepo.Dispose();
        }
    }
}