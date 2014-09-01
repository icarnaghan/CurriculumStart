using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.Business.Dto
{
    public class HabitSubSectionDto
    {
        public Guid Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public Guid SubSectionId { get; set; }
        public bool DeleteHabit { get; set; }

        [UIHint("HabitDropDownList")]
        public HabitListDto Habit { get; set; }
    }
}