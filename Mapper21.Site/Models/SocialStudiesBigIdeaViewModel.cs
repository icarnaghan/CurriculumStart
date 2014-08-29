using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.Site.Models
{
    public class SocialStudiesBigIdeaViewModel
    {
        public Guid Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public Guid SectionId { get; set; }

        [UIHint("SocialStudiesBigIdeaDropDownList")]
        public SocialStudiesBigIdeaListViewModel BigIdeaForSocialStudies{ get; set; }

    }
}