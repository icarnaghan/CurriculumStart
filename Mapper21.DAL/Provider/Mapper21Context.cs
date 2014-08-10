using System.Data.Entity;
using Mapper21.BE.Domain;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.DAL.Provider
{
    public class Mapper21Context : DbContext
    {
        public Mapper21Context() : base("Mapper21Context")
        {
        }

        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionType> SectionTypes { get; set; }
        public DbSet<SectionHabit> SectionHabits { get; set; }
        public DbSet<SectionGuidingQuestion> SectionGuidingQuestions { get; set; }
        public DbSet<SectionBigIdeasForScience> SectionScienceBigIdeases { get; set; }
        public DbSet<SectionBigIdeasForSocialStudies> SectionSocialStudiesBigIdeas { get; set; }

        public DbSet<SubSection> SubSections { get; set; }
        public DbSet<SubSectionType> SubSectionTypes { get; set; }
        public DbSet<SubSectionFieldwork> SubSectionFieldworks { get; set; }
        public DbSet<SubSectionExpert> SubSectionExperts { get; set; }
        public DbSet<SubSectionServiceLearning> SubSectionServiceLearnings { get; set; }
        public DbSet<SubSectionSta> SubSectionStas { get; set; }
        public DbSet<SubSectionStandard> SubSectionStandards { get; set; }
        public DbSet<SubSectionLongTermTarget> SubSectionLongTermTargets { get; set; }
        public DbSet<SubSectionShortTermTarget> SubSectionShortTermTargets { get; set; }
        public DbSet<SubSectionAssessment> SubSectionAssessments { get; set; }
        public DbSet<SubSectionStaGrid> SubSectionStaGrid { get; set; }
        public DbSet<SubSectionGuidingQuestion> SubSectionGuidingQuestions{ get; set; }
        public DbSet<SubSectionHabit> SubSectionHabits { get; set; }

        public DbSet<SubjectArea> SubjectAreas { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<CommonCoreStandard> CommonCoreStandards { get; set; }
        public DbSet<BigIdea> BigIdeas{ get; set; }
        public DbSet<Habit> Habits { get; set; }
    }
}