namespace ExpeditionMapper.Models.Domain
{
    public class GuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpeditionId { get; set; }

        public virtual Expedition Expedition { get; set; }
    }
}