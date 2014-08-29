using System;

namespace Mapper21.Site.Models
{
    public class OtherBigIdeaSubSectionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}