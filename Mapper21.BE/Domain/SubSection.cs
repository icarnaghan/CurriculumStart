using System;
using System.ComponentModel.DataAnnotations.Schema;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.BE.Domain
{
    public class SubSection
    {
        public Guid Id { get; set; }
        public Guid SectionId { get; set; }
        public string SubSectionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public int? SubmittedBy { get; set; }
        public DateTime? SubmittedAt { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        [ForeignKey("SubSectionTypeId")]
        public virtual SubSectionType SubSectionType { get; set; }
    }
}