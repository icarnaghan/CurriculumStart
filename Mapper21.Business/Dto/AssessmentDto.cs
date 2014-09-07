using System;

namespace Mapper21.Business.Dto
{
    public class AssessmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubSectionStaId { get; set; }

        public StaDto SubSectionSta { get; set; }
    }
}