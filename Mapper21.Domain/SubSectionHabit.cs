using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.Domain.LookUps;

namespace Mapper21.Domain
{
    public class SubSectionHabit
    {
        public Guid Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public Guid SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }

        [ForeignKey("HabitId")]
        [UIHint("HabitDropDownList")]
        public Habit Habit { get; set; }
    }
}