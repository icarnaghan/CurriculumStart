using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionExpert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactAddress { get; set; }
        public string ContactCity { get; set; }
        public string ContactZip { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }
    }
}