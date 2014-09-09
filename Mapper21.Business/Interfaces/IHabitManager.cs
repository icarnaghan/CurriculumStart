using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IHabitManager
    {
        IList<GridSelectHabitDto> GetList(Guid Id);
        GridSelectHabitDto Find(Guid id);
        GridSelectHabitDto SaveOrUpdate(GridSelectHabitDto section);
        bool Delete(Guid id);
        void Dispose();
    }
}