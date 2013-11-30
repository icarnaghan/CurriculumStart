using System.Collections.Generic;

namespace ExpeditionMapper.Models.Domain
{
    public class SpringExpedition : Program
    {
        public ICollection<GuidingQuestion> GuidingQuestions { get; set; }
    }
}