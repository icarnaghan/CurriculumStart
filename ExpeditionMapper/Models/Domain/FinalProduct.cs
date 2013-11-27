using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class FinalProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurriculumSegmentId { get; set; }

        [ForeignKey("CurriculumSegmentId")]
        public CurriculumSegment CurriculumSegment { get; set; }
    }
}
