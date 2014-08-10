using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionStandard
    {
        public int Id { get; set; }
        public int SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }
    }
}