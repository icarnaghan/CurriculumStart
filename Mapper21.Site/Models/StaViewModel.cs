using System.ComponentModel;
using Mapper21.Business.Dto;

namespace Mapper21.Site.Models
{
    public class StaViewModel
    {
        public StaDto Sta { get; set; }

        [DisplayName("Long Term Target")]
        public LongTermTargetDto SubSectionLongTermTarget { get; set; }
    }
}