using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SectionHabit
    {
        public int Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }

        [ForeignKey("HabitId")]
        public Habit Habit { get; set; }
    }
}