using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.Domain
{
    public class GuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurriculumSegmentId { get; set; }

        [ForeignKey("CurriculumSegmentId")]
        public CurriculumSegment CurriculumSegment { get; set; }
    }
}