using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SubSectionStandard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StaCollectionId { get; set; }

        [ForeignKey("StaCollectionId")]
        public SubSectionSta StaCollection { get; set; }
    }
}