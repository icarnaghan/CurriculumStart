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

	    public DbSet<Program> Programs { get; set; }
	    public DbSet<GuidingQuestion> GuidingQuestions { get; set; }
	    public DbSet<FinalProduct> FinalProducts { get; set; }
        public DbSet<BigIdeas> BigIdeas { get; set; }

        public System.Data.Entity.DbSet<ExpeditionMapper.Models.Domain.GradeLevel> GradeLevels { get; set; }

        public System.Data.Entity.DbSet<ExpeditionMapper.Models.Domain.FallExpedition> FallExpeditions { get; set; }
	}
}