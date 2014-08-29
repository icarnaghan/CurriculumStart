using System;

namespace Mapper21.Site.Models
{
    public class GuidingQuestionSubSectionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}