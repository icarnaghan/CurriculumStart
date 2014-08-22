using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionSta
    {
        public int Id { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }

        public virtual ICollection<SubSectionStandard> Standards { get; set; }
        public virtual ICollection<SubSectionLongTermTarget> LongTermTargets { get; set; }
        public virtual ICollection<SubSectionShortTermTarget> ShortTermTargets { get; set; }
        public virtual ICollection<SubSectionAssessment> Assessments { get; set; }
    }
}