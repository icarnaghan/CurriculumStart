using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class Habit
    {
        public int Id { get; set; }
        public string Rationale { get; set; }
        public string Description { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}