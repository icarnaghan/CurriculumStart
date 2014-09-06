using System;

namespace Mapper21.Business.Dto
{
    public class SubSectionShortTermTargetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionStaId { get; set; }
        
        public SubSectionStaDto SubSectionSta { get; set; }
    }
}