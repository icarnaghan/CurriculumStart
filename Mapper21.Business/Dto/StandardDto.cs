using System;
using Mapper21.Business.Dto.LookUps;

namespace Mapper21.Business.Dto
{
    public class StandardDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        public StaDto SubSectionSta { get; set; }
        public CommonCoreStandardLookupDto CommonCoreStandard { get; set; }
    }
}