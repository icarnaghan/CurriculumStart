using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mapper21.Business.Dto
{
    public class SubSectionStaDto
    {
        public Guid Id { get; set; }
        public Guid SubSectionId { get; set; }

        public SubSectionDto SubSection { get; set; }
    }                  
}