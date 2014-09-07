using System;

namespace Mapper21.Business.Dto
{
    public class SubSectionHabitDto
    {
        public Guid Id { get; set; }
        public int HabitId { get; set; }
        public string Context { get; set; }
        public Guid SubSectionId { get; set; }
    }
}