using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Domain
{
    public class SubSectionShortTermTarget
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionStaId { get; set; }
        
        [ForeignKey("SubSectionStaId")]
        public SubSectionSta SubSectionSta { get; set; }
    }
}