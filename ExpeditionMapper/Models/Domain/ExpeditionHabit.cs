namespace ExpeditionMapper.Models.Domain
{
    public class ExpeditionHabit
    {
        public int Id { get; set; }
        public string Rationale { get; set; }
        public string Habit { get; set; }
        public int ExpeditionId { get; set; }

        public Expedition Expedition { get; set; }
    }
}