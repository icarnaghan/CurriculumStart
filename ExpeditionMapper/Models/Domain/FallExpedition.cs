using System.Collections.Generic;

namespace ExpeditionMapper.Models.Domain
{
    public class FallExpedition : Program
    {
        public ICollection<GuidingQuestion> GuidingQuestions { get; set; }
    }
}