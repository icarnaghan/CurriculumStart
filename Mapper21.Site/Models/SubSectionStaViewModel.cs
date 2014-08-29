using System.Collections.Generic;
using System.ComponentModel;
using Mapper21.Domain;
using Mapper21.Domain.LookUps;

namespace Mapper21.Site.Models
{
    public class SubSectionStaViewModel
    {
        public SubSectionSta SubSectionSta { get; set; }
        [DisplayName("Long Term Target")]
        public SubSectionLongTermTarget SubSectionLongTermTarget { get; set; }
        public ICollection<SubSectionStandard> SubSectionStandards { get; set; }
        public ICollection<CommonCoreStandard> CommonCoreStandards { get; set; }
    }
}