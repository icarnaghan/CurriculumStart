using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.Models.ViewModels
{
    public class StandardViewModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Description { get; set; }
        public int StandardTargetAssessmentId { get; set; }

        public virtual StandardTargetAssessment StandardTargetAssessment { get; set; }
    }
}