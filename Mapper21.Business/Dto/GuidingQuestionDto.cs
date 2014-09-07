using System;

namespace Mapper21.Business.Dto
{
    public class GuidingQuestionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }

        public SectionDto Section { get; set; }
    }
}