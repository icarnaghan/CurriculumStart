using System;
using Mapper21.Business.Dto.LookUps;

namespace Mapper21.Business.Dto
{
    public class SubSectionStandardDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        public SubSectionStaDto SubSectionSta { get; set; }
        public CommonCoreStandardLookupDto CommonCoreStandard { get; set; }
    }
}