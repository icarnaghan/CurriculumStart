using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class Standard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }

        [ForeignKey("StaCollectionId")]
        public StaCollection StaCollection { get; set; }
    }
}