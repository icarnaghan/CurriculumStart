namespace Mapper21.BE.Domain
{
    public class ScienceBigIdea
    {
        public int Id { get; set; }
        public string Idea { get; set; }
        public string Rationale { get; set; }
        public int SectionId { get; set; }

        public Section Section { get; set; }
    }
}