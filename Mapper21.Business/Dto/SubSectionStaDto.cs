using System;
using System.Collections.Generic;

namespace Mapper21.Business.Dto
{
    public class SubSectionStaDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionId { get; set; }

        public SubSectionDto SubSection { get; set; }

        public IList<SubSectionStandardDto> Standards { get; set; }
        public IList<SubSectionLongTermTargetDto> LongTermTargets { get; set; }
        public IList<SubSectionShortTermTargetDto> ShortTermTargets { get; set; }
        public IList<SubSectionAssessmentDto> Assessments { get; set; }
    }                  
}