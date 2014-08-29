using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.UI.Models
{
    public class HabitViewModel
    {
        public Guid Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }
        public bool DeleteHabit { get; set; }

        [UIHint("HabitDropDownList")]
        public HabitListViewModel Habit { get; set; }
    }
}