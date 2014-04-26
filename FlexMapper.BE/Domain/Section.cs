using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FlexMapper.BE.Domain.LookUps;

namespace FlexMapper.BE.Domain
{
    public class Section
    {
        public int Id { get; set; }
        public int SectionTypeId { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KickOff { get; set; }
        public string FinalProductName { get; set; }
        public string FinalProductDescription { get; set; }

        [ForeignKey("SectionTypeId")]
        public virtual SectionType SectionType { get; set; }

        [ForeignKey("GradeLevelId")]
        public virtual GradeLevel GradeLevel { get; set; }

        public virtual ICollection<CaseStudy> CaseStudies { get; set; }
        public virtual ICollection<GuidingQuestion> GuidingQuestions { get; set; }
        public virtual ICollection<Habit> ExpeditionHabits { get; set; }
        public virtual ICollection<ScienceBigIdea> ScienceBigIdeas { get; set; }
        public virtual ICollection<SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
    }
}