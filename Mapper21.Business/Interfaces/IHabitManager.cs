using System;
using System.Collections.Generic;
using Mapper21.Business.Dto;

namespace Mapper21.Business.Interfaces
{
    public interface IHabitManager
    {
        IList<GridDto> GetSectionHabitList(Guid Id);
        IList<GridDto> GetSubSectionHabitList(Guid Id);
        GridDto FindSectionHabit(Guid id);
        GridDto FindSubSectionHabit(Guid id);
        GridDto SaveOrUpdateSectionHabit(GridDto section);
        GridDto SaveOrUpdateSubSectionHabit(GridDto section);
        bool DeleteSectionHabit(Guid id);
        bool DeleteSubSectionHabit(Guid id);
        void Dispose();
    }
}