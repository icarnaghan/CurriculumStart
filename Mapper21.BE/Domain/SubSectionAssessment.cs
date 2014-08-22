namespace Mapper21.BE.Domain
{
    public class SubSectionAssessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SubSectionStaId { get; set; }

        public SubSectionSta SubSectionSta { get; set; }
    }
}