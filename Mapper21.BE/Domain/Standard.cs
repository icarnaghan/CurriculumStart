using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class Standard
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string StateStandard { get; set; }
        public string GradeLevelId { get; set; }
        public int StaCollectionId { get; set; }

        [ForeignKey("GradeLevelId")]
        public GradeLevel GradeLevel { get; set; }

        [ForeignKey("StaCollectionId")]
        public StaCollection StaCollection { get; set; }
    }
}