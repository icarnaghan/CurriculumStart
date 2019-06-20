using System.ComponentModel.DataAnnotations.Schema;

namespace CurriculumStart.API.Models
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ModuleId")]
        public Module Module { get; set; }

    }
}