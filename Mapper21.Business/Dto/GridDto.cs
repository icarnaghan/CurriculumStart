﻿using System;

namespace Mapper21.Business.Dto
{
    public class GridDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Context { get; set; }
        public string Notes { get; set; }
        public Guid ParentId { get; set; }
        public bool Delete { get; set; }

        public SectionDto Section { get; set; }
    }
}