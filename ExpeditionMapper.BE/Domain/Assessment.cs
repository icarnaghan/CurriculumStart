namespace ExpeditionMapper.BE.Domain
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StaCollectionId { get; set; }

        public StaCollection StaCollection { get; set; }
    }
}