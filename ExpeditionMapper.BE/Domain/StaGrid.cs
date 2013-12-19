namespace ExpeditionMapper.Models.Domain
{
    public class StaGrid
    {
        public int Id { get; set; }
        public int StaCollectionId { get; set; }
        public int CaseStudyId { get; set; }
        public string Standards { get; set; }
        public string LongTermTargets { get; set; }
        public string ShortTermTargets { get; set; }
        public string Assessments { get; set; }
    }
}