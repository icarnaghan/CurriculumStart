namespace ExpeditionMapper.Models.Domain
{
    public class Fieldwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaseStudyId { get; set; }

        public virtual CaseStudy CaseStudy { get; set; }
    }
}