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
        public DbSet<SubSection> SubSections { get; set; }
        public DbSet<SectionType> SectionTypes { get; set; }
        public DbSet<SubSectionType> SubSectionTypes { get; set; }
        public DbSet<SubjectArea> SubjectAreas { get; set; }
        public DbSet<SectionGuidingQuestion> GuidingQuestions { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<SectionHabit> Habits { get; set; }
        public DbSet<SectionBigIdeasForScience> ScienceBigIdeases { get; set; }
        public DbSet<SectionBigIdeasForSocialStudies> SocialStudiesBigIdeas { get; set; }
        public DbSet<SubSectionFieldwork> Fieldworks { get; set; }
        public DbSet<SubSectionExpert> Experts { get; set; }
        public DbSet<SubSectionServiceLearning> ServiceLearnings { get; set; }
        public DbSet<SubSectionSta> StaCollections { get; set; }
        public DbSet<SubSectionStandard> Standards { get; set; }
        public DbSet<SubSectionLongTermTarget> LongTermTargets { get; set; }
        public DbSet<SubSectionShortTermTarget> ShortTermTargets { get; set; }
        public DbSet<SubSectionAssessment> Assessments { get; set; }
        public DbSet<SubSectionStaGrid> StaGrid { get; set; }
        public DbSet<CommonCoreStandard> CommonCoreStandards { get; set; }
        public DbSet<BigIdea> BigIdeas{ get; set; }
    }
}