namespace FlexMapper.BE.Domain
{
    public class Habit
    {
        public int Id { get; set; }
        public string Rationale { get; set; }
        public string Description { get; set; }
        public int ExpeditionId { get; set; }

        public Section Expedition { get; set; }
    }
}