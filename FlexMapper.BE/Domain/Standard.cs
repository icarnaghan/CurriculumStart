namespace Mapper21.BE.Domain
{
    public class Standard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }

        public StaCollection StaCollection { get; set; }
    }
}