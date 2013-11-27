﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpeditionMapper.Models.Domain
{
    public class SpringExpedition : Expedition
    {
        public virtual ICollection<GuidingQuestion> GuidingQuestions{ get; set; }
    }
}