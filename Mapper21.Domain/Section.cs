﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.Domain.LookUps;

namespace Mapper21.Domain
{
    public class Section
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public string GradeLevelId { get; set; }
        public string SectionTypeId { get; set; }
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

        public virtual ICollection<SubSection> SubSections { get; set; }
        public virtual ICollection<SectionGuidingQuestion> GuidingQuestions { get; set; }
        public virtual ICollection<SectionHabit> ExpeditionHabits { get; set; }
        public virtual ICollection<SectionScienceBigIdea> ScienceBigIdeas { get; set; }
        public virtual ICollection<SectionSocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
    }
}