using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExpeditionMapper.Models.Domain;

namespace ExpeditionMapper.Models.ViewModels
{
    public class SocialStudiesBigIdeaViewModel
    {
        public int Id { get; set; }
        public string Idea { get; set; }
        public string Rationale { get; set; }
        public int ExpeditionId { get; set; }
    }
}