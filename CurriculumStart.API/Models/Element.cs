using System.ComponentModel.DataAnnotations.Schema;

namespace CurriculumStart.API.Models
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("SetId")]
        public Set Set { get; set; }
    }
}