using System;

namespace Mapper21.BE.Domain
{
    public class SubSectionStaGrid
    {
        public Guid Id { get; set; }
        public Guid SubSectionStaId { get; set; }
        public Guid SubSectionId { get; set; }
        public string Standards { get; set; }
        public string LongTermTargets { get; set; }
        public string ShortTermTargets { get; set; }
        public string Assessments { get; set; }
    }
}