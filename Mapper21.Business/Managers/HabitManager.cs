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
    public class HabitManager : IHabitManager
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        readonly IGenericDataRepository<SectionHabit> _sectionHabitRepo;
        readonly IGenericDataRepository<SubSectionHabit> _subSectionHabitRepo;

        public HabitManager(IGenericDataRepository<SectionHabit> sectionHabitRepo,
                            IGenericDataRepository<SubSectionHabit> subSectionHabitRepo)
        {
            this._sectionHabitRepo = sectionHabitRepo;
            this._subSectionHabitRepo = subSectionHabitRepo;
            AutoMapperConfig.Init();
        }

        public IList<GridDto> GetSectionList(Guid id)
        {
            IList<SectionHabit> _list;
            _list = _sectionHabitRepo.GetList(s => s.SectionId == id).ToList<SectionHabit>();
            return Mapper.Map<IList<SectionHabit>, IList<GridDto>>(_list);
        }

        public IList<GridDto> GetSubSectionList(Guid id)
        {
            IList<SubSectionHabit> _list;
            _list = _subSectionHabitRepo.GetList(s => s.SubSectionId == id).ToList<SubSectionHabit>();
            return Mapper.Map<IList<SubSectionHabit>, IList<GridDto>>(_list);
        }

        public GridDto FindSection(Guid id)
        {
            SectionHabit habit = _sectionHabitRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(habit);
        }

        public GridDto FindSubSection(Guid id)
        {
            SubSectionHabit habit = _subSectionHabitRepo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridDto>(habit);
        }

        public GridDto SaveOrUpdateSectionHabit(GridDto x)
        {
            SectionHabit p = Mapper.Map<SectionHabit>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _sectionHabitRepo.Add(p);
                }
                else
                {
                    _sectionHabitRepo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public GridDto SaveOrUpdateSubSection(GridDto x)
        {
            SubSectionHabit p = Mapper.Map<SubSectionHabit>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _subSectionHabitRepo.Add(p);
                }
                else
                {
                    _subSectionHabitRepo.Update(p);
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridDto>(p);
        }

        public bool DeleteSection(Guid id)
        {
            try
            {
                GridDto habit = FindSection(id);
                SectionHabit p = Mapper.Map<SectionHabit>(habit);
                _sectionHabitRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSubSection(Guid id)
        {
            try
            {
                GridDto habit = FindSubSection(id);
                SubSectionHabit p = Mapper.Map<SubSectionHabit>(habit);
                _subSectionHabitRepo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _sectionHabitRepo.Dispose();
            _subSectionHabitRepo.Dispose();
        }
    }
}