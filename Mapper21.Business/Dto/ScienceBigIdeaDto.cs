using System;

namespace Mapper21.Business.Dto
{
    public class ScienceBigIdeaDto
    {
        public Guid Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }
    }
}