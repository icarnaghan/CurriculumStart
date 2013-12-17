namespace ExpeditionMapper.Models.Domain
{
    public class LongTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }

        public StaCollection StaCollection { get; set; }
    }
}