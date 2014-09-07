﻿using System;
using System.ComponentModel;

namespace Mapper21.Business.Dto
{
    public class SubSectionLongTermTargetDto
    {
        public Guid Id { get; set; }
        [DisplayName("Long Term Target")]
        public string Name { get; set; }
        public Guid SubSectionStaId { get; set; }

        public SubSectionStaDto SubSectionSta { get; set; }
    }
}