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
    public class OtherBigIdeaManager : IOtherBigIdeaManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SectionOtherBigIdea> _sectionOtherBigIdeaRepo;
        readonly IGenericDataRepository<SubSectionOtherBigIdea> _subSectionOtherBigIdeaRepo;

        public OtherBigIdeaManager(IGenericDataRepository<SectionOtherBigIdea> sectionOtherBigIdeaRepo,
                            IGenericDataRepository<SubSectionOtherBigIdea> subSectionOtherBigIdeaRepo)
        {
            this._sectionOtherBigIdeaRepo = sectionOtherBigIdeaRepo;
            this._subSectionOtherBigIdeaRepo = subSectionOtherBigIdeaRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSectionOtherBigIdeaList(Guid id)
        {
            IList<SectionOtherBigIdea> _list;
            _list = _sectionOtherBigIdeaRepo.GetList(s => s.SectionId == id).ToList<SectionOtherBigIdea>();
            return Mapper.Map<IList<SectionOtherBigIdea>, IList<GridDto>>(_list);
        }

        public IList<GridDto> GetSubSectionOtherBigIdeaList(Guid id)
        {
            IList<SubSectionOtherBigIdea> _list;
            _list = _subSectionOtherBigIdeaRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionOtherBigIdea>();
            return Mapper.Map<IList<SubSectionOtherBigIdea>, IList<GridDto>>(_list);
        }

        public GridDto FindSectionOtherBigIdea(Guid id)
        {
            SectionOtherBigIdea otherBigIdea = _sectionOtherBigIdeaRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(otherBigIdea);
        }

        public GridDto FindSubSectionOtherBigIdea(Guid id)
        {
            SubSectionOtherBigIdea otherBigIdea = _subSectionOtherBigIdeaRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(otherBigIdea);
        }

        public GridDto SaveOrUpdateSectionOtherBigIdea(GridDto x)
        {
            SectionOtherBigIdea p = Mapper.Map<SectionOtherBigIdea>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _sectionOtherBigIdeaRepo.Add(p);
                }
                else
                {
                    _sectionOtherBigIdeaRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public GridDto SaveOrUpdateSubSectionOtherBigIdea(GridDto x)
        {
            SubSectionOtherBigIdea p = Mapper.Map<SubSectionOtherBigIdea>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionOtherBigIdeaRepo.Add(p);
                }
                else
                {
                    _subSectionOtherBigIdeaRepo.Update(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSectionOtherBigIdea(Guid id)
        {
            try
            {
                GridDto otherBigIdea = FindSectionOtherBigIdea(id);
                SectionOtherBigIdea p = Mapper.Map<SectionOtherBigIdea>(otherBigIdea);
                _sectionOtherBigIdeaRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSubSectionOtherBigIdea(Guid id)
        {
            try
            {
                GridDto otherBigIdea = FindSubSectionOtherBigIdea(id);
                SubSectionOtherBigIdea p = Mapper.Map<SubSectionOtherBigIdea>(otherBigIdea);
                _subSectionOtherBigIdeaRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _sectionOtherBigIdeaRepo.Dispose();
            _subSectionOtherBigIdeaRepo.Dispose();
        }
    }
}