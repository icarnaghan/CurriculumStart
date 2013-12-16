namespace ExpeditionMapper.Models.Domain
{
    public class ScienceBigIdea
    {
        public int Id { get; set; }
        public string Idea { get; set; }
        public string Rationale { get; set; }
        public int ExpeditionId { get; set; }

        public virtual Expedition Expedition { get; set; }
    }
}