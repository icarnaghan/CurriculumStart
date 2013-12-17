using System.Data.Entity;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.DAL
{
    public class ExpeditionContext : DbContext
    {
        public ExpeditionContext() : base("ExpeditionContext")
        {
        }

        public DbSet <Expedition> Expeditions { get; set; }
        public DbSet <CaseStudy> CaseStudies { get; set; }
        public DbSet <GuidingQuestion> GuidingQuestions { get; set; }
        public DbSet <GradeLevel> GradeLevels { get; set; }
        public DbSet <ExpeditionHabit> ExpeditionHabits { get; set; }
        public DbSet <ScienceBigIdea> ScienceBigIdeases { get; set; }
        public DbSet <SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
        public DbSet <Fieldwork> Fieldworks { get; set; }
        public DbSet <Expert> Experts { get; set; }
        public DbSet <ServiceLearning> ServiceLearnings { get; set; }
        public DbSet <StaCollection> StaCollections { get; set; }
        public DbSet <Standard> Standards { get; set; }
        public DbSet <LongTermTarget> LongTermTargets { get; set; }
        public DbSet <ShortTermTarget> ShortTermTargets { get; set; }
        public DbSet <Assessment> Assessments { get; set; }
    }
}