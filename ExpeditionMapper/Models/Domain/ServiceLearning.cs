using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class ServiceLearning
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaseStudyId { get; set; }

        [ForeignKey("CaseStudyId")]
        public CaseStudy CaseStudy { get; set; }
    }
}