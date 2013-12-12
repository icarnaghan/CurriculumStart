﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ExpeditionMapper.Models.Domain
{
    public class Expert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CaseStudyId { get; set; }

        [ForeignKey("CaseStudyId")]
        public CaseStudy CaseStudy { get; set; }
    }
}