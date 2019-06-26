using System;
using System.Collections.Generic;

namespace CurriculumStart.API.Models
{
    public class UserMap
    {
        public int UserId { get; set; }
        public User Users { get; set; }
        public int MapId { get; set; }
        public Map Maps { get; set; }
    }
}