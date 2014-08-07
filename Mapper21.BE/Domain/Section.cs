using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class Section
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public int SectionTypeId { get; set; }
        public int? SubjectAreaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KickOff { get; set; }
        public string FinalProductName { get; set; }
        public string FinalProductDescription { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public int? SubmittedBy { get; set; }
        public DateTime? SubmittedAt { get; set; }

        [ForeignKey("GradeLevelId")]
        public virtual GradeLevel GradeLevel { get; set; }

        [ForeignKey("SectionTypeId")]
        public virtual SectionType SectionType { get; set; }

        [ForeignKey("SubjectAreaId")]
        public virtual SubjectArea SubjectArea { get; set; }

        public virtual ICollection<SubSection> SubSections { get; set; }
        public virtual ICollection<GuidingQuestion> GuidingQuestions { get; set; }
        public virtual ICollection<Habit> ExpeditionHabits { get; set; }
        public virtual ICollection<ScienceBigIdea> ScienceBigIdeas { get; set; }
        public virtual ICollection<SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
    }
}