

namespace ScoreCardPlus.Models
{
    public class ScoreCard 
    {
        
        public Guid ID { get; set; }
        public string? Course { get; set; }
        public int NumberofHoles { get; set; }
        public int ParCourseTotal { get; set; }
        public int NumberofPlayers { get; set; }
        
        
    }
}
