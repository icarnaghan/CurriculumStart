using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Domain
{
    public class SectionOtherBigIdea
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }
        
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}