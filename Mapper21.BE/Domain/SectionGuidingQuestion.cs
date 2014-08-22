using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SectionGuidingQuestion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}