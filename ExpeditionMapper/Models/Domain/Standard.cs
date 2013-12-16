namespace ExpeditionMapper.Models.Domain
{
    public class Standard
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Description { get; set; }
        public int CaseStudyId { get; set; }

        public CaseStudy CaseStudy { get; set; }
    }
}