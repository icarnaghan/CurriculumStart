using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Domain
{
    public class SubSectionSta
    {
        public Guid Id { get; set; }
        public Guid SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }

        public IList<SubSectionStandard> Standards { get; set; }
        public IList<SubSectionLongTermTarget> LongTermTargets { get; set; }
        public IList<SubSectionShortTermTarget> ShortTermTargets { get; set; }
        public IList<SubSectionAssessment> Assessments { get; set; }
    }
}