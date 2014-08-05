using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SubSection
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int SubSectionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        [ForeignKey("SubSectionTypeId")]
        public virtual SubSectionType SubSectionType { get; set; }
    }
}