using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Domain
{
    public class SubSectionLongTermTarget
    {
        public Guid Id { get; set; }
        [DisplayName("Long Term Target")]
        public string Name { get; set; }
        public Guid SubSectionStaId { get; set; }

        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }
    }
}