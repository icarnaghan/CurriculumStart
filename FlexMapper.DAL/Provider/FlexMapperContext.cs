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
        public DbSet<CaseStudy> CaseStudies { get; set; }
        public DbSet<GuidingQuestion> GuidingQuestions { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<ScienceBigIdea> ScienceBigIdeases { get; set; }
        public DbSet<SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
        public DbSet<Fieldwork> Fieldworks { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ServiceLearning> ServiceLearnings { get; set; }
        public DbSet<StaCollection> StaCollections { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<LongTermTarget> LongTermTargets { get; set; }
        public DbSet<ShortTermTarget> ShortTermTargets { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<StaGrid> StaGrid { get; set; }
    }
}