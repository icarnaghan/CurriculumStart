namespace ExpeditionMapper.Models.Domain
{
    public class ShortTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StandardTargetAssessmentId { get; set; }

        public virtual StandardTargetAssessment StandardTargetAssessment { get; set; }
    }
}