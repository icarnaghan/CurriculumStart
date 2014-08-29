using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.UI.Models
{
    public class ScienceBigIdeaViewModel
    {
        public Guid Id { get; set; }
        public int BigIdeaForScienceId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }
    }
}