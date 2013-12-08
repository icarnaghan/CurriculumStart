using System.ComponentModel.DataAnnotations.Schema;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.Models.Domain
{
    public class ScienceBigIdea
    {
        public int Id { get; set; }
        public string Idea { get; set; }
        public string Rationale { get; set; }
        public int ExpeditionId { get; set; }

        public Expedition Expedition { get; set; }
    }
}
