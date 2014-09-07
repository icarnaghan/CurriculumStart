using System;
using System.Collections.Generic;

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
        public IList<GuidingQuestionDto> GuidingQuestions { get; set; }
        public IList<HabitDto> ExpeditionHabits { get; set; }
        public IList<ScienceBigIdeaDto> ScienceBigIdeas { get; set; }
        public IList<SocialStudiesBigIdeaDto> SocialStudiesBigIdeas { get; set; }
    }
}