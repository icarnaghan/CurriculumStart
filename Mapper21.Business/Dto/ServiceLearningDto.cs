using System;

namespace Mapper21.Business.Dto
{
    public class ServiceLearningDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Guid SubSectionId { get; set; }
    }
}