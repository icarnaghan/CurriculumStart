﻿using System;

namespace Mapper21.Business.Dto
{
    public class OtherBigIdeaSubSectionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubSectionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}