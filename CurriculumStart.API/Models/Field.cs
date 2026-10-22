using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.WebRequestMethods;

namespace CurriculumStart.API.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("ElementId")]
        public Element Element { get; set; }
    }
}