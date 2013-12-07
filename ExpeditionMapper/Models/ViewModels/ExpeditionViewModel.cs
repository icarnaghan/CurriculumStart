using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.Models.ViewModels
{
    public class ExpeditionViewModel
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KickOff { get; set; }
        public string FinalProductName { get; set; }
        public string FinalProductDescription { get; set; }

        public virtual GradeLevel GradeLevel { get; set; }
        public virtual ICollection<GuidingQuestion> GuidingQuestions { get; set; }
    }
}