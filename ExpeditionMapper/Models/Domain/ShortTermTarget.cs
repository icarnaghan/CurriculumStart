namespace ExpeditionMapper.Models.Domain
{
    public class ShortTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaseStudyId { get; set; }

        public CaseStudy CaseStudy { get; set; }
    }
}