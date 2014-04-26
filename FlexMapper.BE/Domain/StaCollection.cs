using System.Collections.Generic;

namespace FlexMapper.BE.Domain
{
    public class StaCollection
    {
        public int Id { get; set; }
        public int CaseStudyId { get; set; }

        public virtual CaseStudy CaseStudy { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
        public virtual ICollection<LongTermTarget> LongTermTargets { get; set; }
        public virtual ICollection<ShortTermTarget> ShortTermTargets { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}