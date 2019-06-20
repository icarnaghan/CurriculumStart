using System;

namespace CurriculumStart.API.Models
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string GradeLower { get; set; }
        public string GradeUpper { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public int Order { get; set; }

    }
}