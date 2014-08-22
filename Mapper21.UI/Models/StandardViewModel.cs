using System.ComponentModel.DataAnnotations;

namespace Mapper21.UI.Models
{
    public class StandardViewModel
    {
        public int Id { get; set; }
        public int CommonCoreStandardId { get; set; }
        public int SubSectionStaId { get; set; }

        [UIHint("StandardDropDownList")]
        public StandardListViewModel Standard { get; set; }
    }
}