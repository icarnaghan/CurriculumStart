using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.Business.Dto
{
    public class SocialStudiesBigIdeaDto
    {
        public Guid Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        [UIHint("SocialStudiesBigIdeaDropDownList")]
        public SocialStudiesBigIdeaListDto BigIdeaForSocialStudies{ get; set; }

    }
}