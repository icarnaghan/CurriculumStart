using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.BE.Domain
{
    public class SubSectionOtherBigIdea
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public Guid SubSectionId { get; set; }
        
        [ForeignKey("SubSectionId")]
        public SubSection SubSection { get; set; }
    }
}