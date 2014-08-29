using System;

namespace Mapper21.Site.Models
{
    public class ScienceBigIdeaViewModel
    {
        public Guid Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }
    }
}