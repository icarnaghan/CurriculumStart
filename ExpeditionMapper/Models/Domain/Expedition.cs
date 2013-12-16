using System.Collections.Generic;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.Models.Domain
{
    public class Expedition
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
        public virtual ICollection<CaseStudy> CaseStudies { get; set; }
        public virtual ICollection<GuidingQuestion> GuidingQuestions { get; set; }
        public virtual ICollection<ExpeditionHabit> ExpeditionHabits { get; set; }
        public virtual ICollection<ScienceBigIdea> ScienceBigIdeas { get; set; }
        public virtual ICollection<SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
    }
}