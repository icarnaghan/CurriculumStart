using System.Collections.Generic;
using System.ComponentModel;
using Mapper21.Business.Dto;
using Mapper21.Business.Dto.LookUps;

namespace Mapper21.Site.Models
{
    public class SubSectionStaViewModel
    {
        public SubSectionStaDto SubSectionSta { get; set; }
        [DisplayName("Long Term Target")]
        public SubSectionLongTermTargetDto SubSectionLongTermTarget { get; set; }
        public IList<SubSectionStandardDto> SubSectionStandards { get; set; }
        public IList<CommonCoreStandardLookupDto> CommonCoreStandards { get; set; }
    }
}