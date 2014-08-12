using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionLongTermTarget
    {
        public int Id { get; set; }
        [DisplayName("Long Term Target")]
        public string Name { get; set; }
        public int SubSectionStaId { get; set; }

        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }
    }
}