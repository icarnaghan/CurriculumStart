using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class GuidingQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }

        public virtual Program Program { get; set; }
    }
}