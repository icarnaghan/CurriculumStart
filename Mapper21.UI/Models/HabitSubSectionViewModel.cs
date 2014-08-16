using System.ComponentModel.DataAnnotations;
using Mapper21.BE.Domain.LookUps;

namespace Mapper21.UI.Models
{
    public class HabitSubSectionViewModel
    {
        public int Id { get; set; } 
        public int HabitId { get; set; }
        public string Context { get; set; }
        public int SubSectionId { get; set; }

        [UIHint("HabitDropDownList")]
        public HabitListViewModel Habit { get; set; }
    }
}