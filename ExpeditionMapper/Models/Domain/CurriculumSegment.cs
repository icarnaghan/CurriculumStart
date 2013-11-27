using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.Domain
{
    public class CurriculumSegment
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}