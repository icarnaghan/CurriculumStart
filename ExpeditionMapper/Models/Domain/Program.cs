using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;

namespace ExpeditionMapper.Models.Domain
{
    public class Program
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("GradeLevelId")]
        public GradeLevel GradeLevel { get; set; }
    }
}