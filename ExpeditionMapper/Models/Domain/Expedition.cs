using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.Models.Domain
{
    public class Expedition
    {
        public Expedition()
        {
            this.GuidingQuestions = new HashSet<GuidingQuestion>();
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string KickOff { get; set; }
        public string FinalProductName { get; set; }
        public string FinalProductDescription { get; set; }

        [ForeignKey("GradeLevelId")]
        public virtual GradeLevel GradeLevel { get; set; }

        public virtual ICollection<GuidingQuestion> GuidingQuestions { get; set; }

        internal void CreateGuidingQuestions(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                GuidingQuestions.Add(new GuidingQuestion());
            }
        }
    }
}