using ExpeditionMapper.Models.Domain;
using ExpeditionMapper.Models.Domain.LookUps;

namespace ExpeditionMapper.Models.ViewModels
{
    public class ExpeditionHabitViewModel
    {
        public int Id { get; set; }
        public string Rationale { get; set; }
        public string Habit { get; set; }
        public int ExpeditionId { get; set; }
    }
}