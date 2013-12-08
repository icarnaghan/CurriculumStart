using System.Data.Entity;
using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.DAL
{
	public class ExpeditionContext : DbContext
	{
        public ExpeditionContext(): base("ExpeditionContext")
	    {    
	    }
	    public DbSet<Expedition> Expeditions { get; set; }
	    public DbSet<GuidingQuestion> GuidingQuestions { get; set; }
        public DbSet<BigIdeas> BigIdeas { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
	    public DbSet<ExpeditionHabit> ExpeditionHabits { get; set; }
	    public DbSet<ScienceBigIdea> ScienceBigIdeases { get; set; }
	    public DbSet<SocialStudiesBigIdea> SocialStudiesBigIdeas { get; set; }
	}
}