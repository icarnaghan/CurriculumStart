using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.Site.Models
{
    public class StandardViewModel
    {
        public Guid Id { get; set; }
        public int CommonCoreStandardId { get; set; }
        public Guid SubSectionStaId { get; set; }

        [UIHint("StandardDropDownList")]
        public StandardListViewModel CommonCoreStandard { get; set; }
    }
}