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
    public class ScienceBigIdeaManager : IScienceBigIdeaManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SectionScienceBigIdea> _sectionScienceBigIdeaRepo;

        public ScienceBigIdeaManager(IGenericDataRepository<SectionScienceBigIdea> sectionScienceBigIdeaRepo)
        {
            this._sectionScienceBigIdeaRepo = sectionScienceBigIdeaRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSectionScienceBigIdeaList(Guid id)
        {
            IList<SectionScienceBigIdea> _list;
            _list = _sectionScienceBigIdeaRepo.GetList(s => s.SectionId == id).ToList<SectionScienceBigIdea>();
            return Mapper.Map<IList<SectionScienceBigIdea>, IList<GridDto>>(_list);
        }

        public GridDto FindSectionScienceBigIdea(Guid id)
        {
            SectionScienceBigIdea scienceBigIdea = _sectionScienceBigIdeaRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(scienceBigIdea);
        }

        public GridDto SaveOrUpdateSectionScienceBigIdea(GridDto x)
        {
            SectionScienceBigIdea p = Mapper.Map<SectionScienceBigIdea>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _sectionScienceBigIdeaRepo.Add(p);
                }
                else
                {
                    _sectionScienceBigIdeaRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSectionScienceBigIdea(Guid id)
        {
            try
            {
                GridDto scienceBigIdea = FindSectionScienceBigIdea(id);
                SectionScienceBigIdea p = Mapper.Map<SectionScienceBigIdea>(scienceBigIdea);
                _sectionScienceBigIdeaRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _sectionScienceBigIdeaRepo.Dispose();
        }
    }
}