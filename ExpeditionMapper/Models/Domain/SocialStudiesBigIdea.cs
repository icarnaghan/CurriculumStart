namespace ExpeditionMapper.Models.Domain
{
    public class SocialStudiesBigIdea
    {
        public int Id { get; set; }
        public string Idea { get; set; }
        public string Rationale { get; set; }
        public int ExpeditionId { get; set; }

        public virtual Expedition Expedition { get; set; }
    }
}