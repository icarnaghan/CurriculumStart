using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IHabitManager
    {
        IList<HabitDto> GetList(Guid Id);
        HabitDto Find(Guid id);
        HabitDto SaveOrUpdate(HabitDto section);
        bool Delete(Guid id);
        void Dispose();
    }
}