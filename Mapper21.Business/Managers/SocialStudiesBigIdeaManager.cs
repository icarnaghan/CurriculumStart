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
    public class SocialStudiesBigIdeaManager : ISocialStudiesBigIdeaManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SectionSocialStudiesBigIdea> _sectionSocialStudiesBigIdeaRepo;

        public SocialStudiesBigIdeaManager(IGenericDataRepository<SectionSocialStudiesBigIdea> sectionSocialStudiesBigIdeaRepo)
        {
            this._sectionSocialStudiesBigIdeaRepo = sectionSocialStudiesBigIdeaRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetList(Guid id)
        {
            IList<SectionSocialStudiesBigIdea> _list;
            _list = _sectionSocialStudiesBigIdeaRepo.GetList(s => s.SectionId == id).ToList<SectionSocialStudiesBigIdea>();
            return Mapper.Map<IList<SectionSocialStudiesBigIdea>, IList<GridDto>>(_list);
        }

        public GridDto Find(Guid id)
        {
            SectionSocialStudiesBigIdea socialStudiesBigIdea = _sectionSocialStudiesBigIdeaRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(socialStudiesBigIdea);
        }

        public GridDto SaveOrUpdate(GridDto x)
        {
            SectionSocialStudiesBigIdea p = Mapper.Map<SectionSocialStudiesBigIdea>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _sectionSocialStudiesBigIdeaRepo.Add(p);
                }
                else
                {
                    _sectionSocialStudiesBigIdeaRepo.Update(p);                 
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
                GridDto socialStudiesBigIdea = Find(id);
                SectionSocialStudiesBigIdea p = Mapper.Map<SectionSocialStudiesBigIdea>(socialStudiesBigIdea);
                _sectionSocialStudiesBigIdeaRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _sectionSocialStudiesBigIdeaRepo.Dispose();
        }
    }
}