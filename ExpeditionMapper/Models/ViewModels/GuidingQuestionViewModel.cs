namespace ExpeditionMapper.Models.ViewModels
{
    public class GuidingQuestionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpeditionId { get; set; }
        public bool DeleteGuidingQuestion { get; set; }
    }
}