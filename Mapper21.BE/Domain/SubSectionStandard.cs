using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SubSectionStandard
    {
        public int Id { get; set; }
        public int SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }

        [ForeignKey("CommonCoreStandardId")]
        [UIHint("StandardDropDownList")]
        public CommonCoreStandard CommonCoreStandard { get; set; }
    }
}