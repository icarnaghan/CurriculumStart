using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.Domain
{
    public class Fsw : CurriculumSegment
    {
        public string KickOff { get; set; }
        public virtual ICollection<GuidingQuestion> GuidingQuestions{ get; set; }
    }
}