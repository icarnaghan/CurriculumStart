using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class StaCollection
    {
        public int Id { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }

        public virtual ICollection<Standard> Standards { get; set; }
        public virtual ICollection<LongTermTarget> LongTermTargets { get; set; }
        public virtual ICollection<ShortTermTarget> ShortTermTargets { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}