namespace Mapper21.BE.Domain
{
    public class SubSectionStaGrid
    {
        public int Id { get; set; }
        public int SubSectionStaId { get; set; }
        public int SubSectionId { get; set; }
        public string Standards { get; set; }
        public string LongTermTargets { get; set; }
        public string ShortTermTargets { get; set; }
        public string Assessments { get; set; }
    }
}