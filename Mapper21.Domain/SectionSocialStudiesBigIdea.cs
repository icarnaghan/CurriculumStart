using System;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.Domain.LookUps;

namespace Mapper21.Domain
{
    public class SectionSocialStudiesBigIdea
    {
        public Guid Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        [ForeignKey("BigIdeaForSocialStudiesId")]
        public SocialStudiesBigIdea BigIdeaForSocialStudies { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}