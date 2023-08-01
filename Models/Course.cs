using System.Security.Cryptography.X509Certificates;

namespace ScoreCardPlus.Models
{
    public class Course : ScoreCard
    {
      
        public string Name { get; set; }
        public string Description { get; set; }
        public int HoleNumber { get; set; }
        public int DistanceinYards { get; set; }
        public int ParScore { get; set; }


        public Course()
        {
            HoleNumber = (1-18);
            DistanceinYards = (1-600);
            ParScore = new int();
        }

    }
}
