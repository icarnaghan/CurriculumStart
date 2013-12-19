namespace ExpeditionMapper.BE.Domain
{
    public class ShortTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }

        public StaCollection StaCollection { get; set; }
    }
}