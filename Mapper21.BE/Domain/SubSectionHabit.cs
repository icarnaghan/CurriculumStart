using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SubSectionHabit
    {
        public int Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }

        [ForeignKey("HabitId")]
        [UIHint("HabitDropDownList")]
        public Habit Habit { get; set; }
    }
}