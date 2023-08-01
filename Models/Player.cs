namespace ScoreCardPlus.Models
{
    public class Player : ScoreCard
    {
    
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int HandicapRating { get; set; }
    }
}
