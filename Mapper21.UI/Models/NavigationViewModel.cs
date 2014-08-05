using System.Collections.Generic;
using Mapper21.BE.Domain;

namespace Mapper21.UI.Models
{
    public class NavigationViewModel
    {
        public int? SelectedSectionId { get; set; }
        public int? SelectedCaseStudyId { get; set; }
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<SubSection> CaseStudies { get; set; }
    }
}