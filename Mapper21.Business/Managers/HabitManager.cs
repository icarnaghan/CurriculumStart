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
        IGenericDataRepository<SectionHabit> _repo;

        public HabitManager(IGenericDataRepository<SectionHabit> repo)
        {
            this._repo = repo;
            AutoMapperConfig.Init();
        }

        public IList<GridSelectHabitDto> GetList(Guid id)
        {
            IList<SectionHabit> _list;
            _list = _repo.GetList(s => s.SectionId == id).ToList<SectionHabit>();
            return Mapper.Map<IList<SectionHabit>, IList<GridSelectHabitDto>>(_list);
        }

        public GridSelectHabitDto Find(Guid id)
        {
            SectionHabit habit = _repo.GetSingle(x => x.Id == id);
            return Mapper.Map<GridSelectHabitDto>(habit);
        }

        public GridSelectHabitDto SaveOrUpdate(GridSelectHabitDto x)
        {
            SectionHabit p = Mapper.Map<SectionHabit>(x);
            try
            {
                if (p.Id == default(Guid))
                {
                    p.Id = Guid.NewGuid();
                    _repo.Add(p);
                }
                else
                {
                    _repo.Update(p);                 
                }

            }
            catch (Exception e)
            {
                log.Error(e);
            }
            return Mapper.Map<GridSelectHabitDto>(p);
        }

        public bool Delete(Guid id)
        {
            try
            {
                GridSelectHabitDto habit = Find(id);
                SectionHabit p = Mapper.Map<SectionHabit>(habit);
                _repo.Remove(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}