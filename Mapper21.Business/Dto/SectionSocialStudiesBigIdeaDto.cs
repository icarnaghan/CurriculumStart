using System;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business.Dto
{
    public class SectionSocialStudiesBigIdeaDto
    {
        public Guid Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        public SocialStudiesBigIdea BigIdeaForSocialStudies { get; set; }
        public SectionDto Section { get; set; }
    }
}