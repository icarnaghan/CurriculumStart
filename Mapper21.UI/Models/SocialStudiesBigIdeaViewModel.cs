using System.ComponentModel.DataAnnotations;

namespace Mapper21.UI.Models
{
    public class SocialStudiesBigIdeaViewModel
    {
        public int Id { get; set; }
        public int BigIdeaForSocialStudiesId { get; set; }
        public string Context { get; set; }
        public int SectionId { get; set; }

        [UIHint("SocialStudiesBigIdeaDropDownList")]
        public BigIdeaForSocialStudiesListViewModel BigIdeaForSocialStudies{ get; set; }

    }
}