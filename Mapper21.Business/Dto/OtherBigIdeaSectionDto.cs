using System;

namespace Mapper21.Business.Dto
{
    public class OtherBigIdeaSectionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}