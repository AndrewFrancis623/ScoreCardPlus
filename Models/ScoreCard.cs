namespace ScoreCardPlus.Models
{
    public class ScoreCard
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public string? CourseName { get; set; }
        public List<Holes>? Hole { get; set; }
        public int ParScore { get; set; }
        public string? UserName { get; set; }
        public int UserScore { get; set; }   
        
    }
}
