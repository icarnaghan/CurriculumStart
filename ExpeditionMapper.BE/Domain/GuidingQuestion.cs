using System.ComponentModel.DataAnnotations.Schema;

namespace FlexMapper.BE.Domain
{
    public class GuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpeditionId { get; set; }

        [ForeignKey("ExpeditionId")]
        public Section Expedition { get; set; }
    }
}