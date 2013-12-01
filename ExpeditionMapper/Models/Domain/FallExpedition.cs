using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class FallExpedition : Program
    {
        public int BigIdeasId { get; set; }

        [ForeignKey("BigIdeasId")]
        public BigIdeasScience BigIdeasScience { get; set; }

    }
}