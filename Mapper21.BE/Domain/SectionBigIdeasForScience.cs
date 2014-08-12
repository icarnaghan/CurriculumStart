using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SectionBigIdeasForScience
    {
        public int Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("BigIdeaForScienceId")]
        public BigIdeaForScience BigIdeaForScience { get; set; }
        
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}