using System.Data.Entity;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.DAL
{
	public class ExpeditionContext : DbContext
	{
        public ExpeditionContext(): base("ExpeditionContext")
	    {    
	    }

	    public DbSet<Program> Programs { get; set; }
	    public DbSet<FswSemester> FswSemesters { get; set; }
	    public DbSet<FallExpedition> FallExpeditions { get; set; }
	    public DbSet<MiniSemester> MiniSemesters { get; set; }
	    public DbSet<SpringExpedition> SpringExpeditions { get; set; }
	    public DbSet<GuidingQuestion> GuidingQuestions { get; set; }
	    public DbSet<FinalProduct> FinalProducts { get; set; }
	}
}