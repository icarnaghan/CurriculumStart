using System;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business.Dto
{
    public class SectionScienceBigIdeaDto
    {
        public Guid Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        public ScienceBigIdea BigIdeaForScience { get; set; }
        public SectionDto Section { get; set; }
    }
}