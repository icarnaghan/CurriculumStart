using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.UI.Models
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