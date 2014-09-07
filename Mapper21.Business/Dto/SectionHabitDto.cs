using System;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business.Dto
{
    public class SectionHabitDto
    {
        public Guid Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        public SectionDto Section { get; set; }
        public Habit Habit { get; set; }
    }
}