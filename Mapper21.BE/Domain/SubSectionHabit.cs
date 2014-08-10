using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionHabit
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public string Description { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }
    }
}