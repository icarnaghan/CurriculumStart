using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurriculumStart.API.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public int Order { get; set; }
        [ForeignKey("MapId")]
        public Map Map { get; set; }
        
    }
}