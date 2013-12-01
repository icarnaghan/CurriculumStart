using System.Collections.Generic;

namespace ExpeditionMapper.Models.Domain
{
    public abstract class Program
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}