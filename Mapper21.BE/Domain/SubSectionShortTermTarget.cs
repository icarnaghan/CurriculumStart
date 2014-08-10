using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionShortTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubSectionStaId { get; set; }
        
        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }
    }
}