using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.Domain.LookUps;

namespace Mapper21.Domain
{
    public class SubSectionStandard
    {
        public Guid Id { get; set; }
        public Guid SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }

        [ForeignKey("CommonCoreStandardId")]
        [UIHint("StandardDropDownList")]
        public CommonCoreStandard CommonCoreStandard { get; set; }
    }
}