using Microsoft.AspNet.Identity.EntityFramework;

namespace Mapper21.UI.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Mapper21Context")
        {
        }
    }
}