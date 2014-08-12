using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SectionBigIdeasForSocialStudies
    {
        public int Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("BigIdeaForSocialStudiesId")]
        public BigIdeaForSocialStudies BigIdeaForSocialStudies { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
    }
}