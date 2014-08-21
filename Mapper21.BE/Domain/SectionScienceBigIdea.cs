using System;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SectionScienceBigIdea
    {
        public Guid Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        [ForeignKey("BigIdeaForScienceId")]
        public ScienceBigIdea BigIdeaForScience { get; set; }
        
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}