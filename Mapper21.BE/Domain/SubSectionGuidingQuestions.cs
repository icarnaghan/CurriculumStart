using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionGuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection Section { get; set; }
    }
}