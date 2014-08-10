using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionBigIdeaOther
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public int SubSectionId { get; set; }
        
        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }
    }
}