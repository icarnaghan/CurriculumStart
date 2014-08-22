using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SectionSocialStudiesBigIdea
    {
        public int Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("BigIdeaForSocialStudiesId")]
        public SocialStudiesBigIdea BigIdeaForSocialStudies { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}