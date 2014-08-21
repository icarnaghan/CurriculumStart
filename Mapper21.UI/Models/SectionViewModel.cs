using System;

namespace Mapper21.UI.Models
{
    public class SectionViewModel
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KickOff { get; set; }
        public string FinalProductName { get; set; }
        public string FinalProductDescription { get; set; }
    }
}