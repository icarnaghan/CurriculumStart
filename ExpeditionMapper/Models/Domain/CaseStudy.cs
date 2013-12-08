using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.Models.Domain
{
    public class CaseStudy
    {
        public int Id { get; set; }
        public int ExpeditionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Expedition Expedition { get; set; }
    }
}