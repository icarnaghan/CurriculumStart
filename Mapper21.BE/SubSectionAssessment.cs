using System;

namespace Mapper21.Domain
{
    public class SubSectionAssessment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubSectionStaId { get; set; }

        public SubSectionSta SubSectionSta { get; set; }
    }
}