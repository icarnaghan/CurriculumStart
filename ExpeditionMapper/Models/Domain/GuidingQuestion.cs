using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class GuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpeditionId { get; set; }

        [ForeignKey("ExpeditionId")]
        public Expedition Expedition { get; set; }
    }
}