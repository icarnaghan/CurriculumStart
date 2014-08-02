using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mapper21.UI.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
        public int GradeLevelId { get; set; }

        [ForeignKey("GradeLevelId")]
        public GradeLevel GradeLevel { get; set; }
    }
}