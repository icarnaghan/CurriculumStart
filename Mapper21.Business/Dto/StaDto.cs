using System;
using System.Collections.Generic;

namespace Mapper21.Business.Dto
{
    public class StaDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionId { get; set; }

        public SubSectionDto SubSection { get; set; }

        public IList<StandardDto> Standards { get; set; }
        public IList<LongTermTargetDto> LongTermTargets { get; set; }
        public IList<ShortTermTargetDto> ShortTermTargets { get; set; }
        public IList<AssessmentDto> Assessments { get; set; }
    }                  
}