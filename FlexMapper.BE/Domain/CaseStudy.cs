namespace Mapper21.BE.Domain
{
    public class CaseStudy
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Section Section { get; set; }
    }
}