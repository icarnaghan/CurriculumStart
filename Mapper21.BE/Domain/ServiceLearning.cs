using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class ServiceLearning
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaseStudyId { get; set; }

        [ForeignKey("CaseStudyId")]
        public CaseStudy CaseStudy { get; set; }
    }
}