using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Domain
{
    public class SubSectionGuidingQuestion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionId { get; set; }

        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }
    }
}