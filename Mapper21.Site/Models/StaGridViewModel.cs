using System;

namespace Mapper21.Site.Models
{
    public class StaGridViewModel
    {
        public Guid Id { get; set; }
        public int StaCollectionId { get; set; }
        public int CaseStudyId { get; set; }
        public string Standards { get; set; }
        public string LongTermTargets { get; set; }
        public string ShortTermTargets { get; set; }
        public string Assessments { get; set; }
    }
}