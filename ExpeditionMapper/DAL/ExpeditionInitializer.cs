using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExpeditionMapper.DAL;

namespace ExpeditionMapper.DAL
{
    public class ExpeditionInitializer : DropCreateDatabaseIfModelChanges<ExpeditionContext>
    {
        protected override void Seed(ExpeditionContext context)
        {
        }
    }
}