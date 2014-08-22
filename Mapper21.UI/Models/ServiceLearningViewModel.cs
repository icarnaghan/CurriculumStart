using System;

namespace Mapper21.UI.Models
{
    public class ServiceLearningViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Guid SubSectionId { get; set; }
    }
}