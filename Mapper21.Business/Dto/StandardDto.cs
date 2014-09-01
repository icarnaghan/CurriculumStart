using System;
using System.ComponentModel.DataAnnotations;

namespace Mapper21.Business.Dto
{
    public class StandardDto
    {
        public Guid Id { get; set; }
        public int CommonCoreStandardId { get; set; }
        public Guid SubSectionStaId { get; set; }

        [UIHint("StandardDropDownList")]
        public StandardListDto CommonCoreStandard { get; set; }
    }
}