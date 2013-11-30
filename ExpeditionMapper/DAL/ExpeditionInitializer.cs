using System.Data.Entity;

namespace ExpeditionMapper.DAL
{
    public class ExpeditionInitializer : DropCreateDatabaseIfModelChanges<ExpeditionContext>
    {
        protected override void Seed(ExpeditionContext context)
        {
        }
    }
}