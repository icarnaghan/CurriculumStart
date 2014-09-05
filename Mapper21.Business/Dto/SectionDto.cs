﻿using System;
using System.Collections.Generic;
using Mapper21.Domain;


namespace Mapper21.Business.Dto
{
    public class SectionDto
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

        public IList<SubSectionDto> SubSections { get; set; }
        public IList<SectionGuidingQuestionDto> GuidingQuestions { get; set; }
        public IList<SectionHabitDto> ExpeditionHabits { get; set; }
        public IList<SectionScienceBigIdeaDto> ScienceBigIdeas { get; set; }
        public IList<SectionSocialStudiesBigIdeaDto> SocialStudiesBigIdeas { get; set; }
    }
}