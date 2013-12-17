namespace ExpeditionMapper.Models.Domain
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaseStudyId { get; set; }

        public CaseStudy CaseStudy { get; set; }
    }
}