using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionShortTermTarget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }
        
        [ForeignKey("StaCollectionId")]
        public SubSectionSta StaCollection { get; set; }
    }
}