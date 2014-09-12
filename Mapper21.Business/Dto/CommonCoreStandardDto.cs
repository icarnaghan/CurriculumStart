using System;

namespace Mapper21.Business.Dto
{
    public class CommonCoreStandardDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionStaId { get; set; }
        public int CommonCoreStandardId { get; set; }

        public StaDto SubSectionSta { get; set; }
    }
}