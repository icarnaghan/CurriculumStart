using System;
using Mapper21.Domain;
using Mapper21.Domain.LookUps;

namespace Mapper21.Business.Dto
{
    public class SubSectionDto
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

        public Section Section { get; set; }
        public SubSectionType SubSectionType { get; set; }
    }
}