using System;

namespace Mapper21.UI.Models
{
    public class GuidingQuestionSectionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}