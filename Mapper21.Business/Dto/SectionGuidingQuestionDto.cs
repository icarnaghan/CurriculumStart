using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Business.Dto
{
    public class SectionGuidingQuestionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SectionId { get; set; }

        public SectionDto Section { get; set; }
    }
}