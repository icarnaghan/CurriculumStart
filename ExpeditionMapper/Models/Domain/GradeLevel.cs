using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.Domain
{
    public class GradeLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Program> Programs { get; set; }
    }
}