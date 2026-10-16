namespace WebApplication1.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Availability { get; set; } = string.Empty; 
        public string Status { get; set; } = string.Empty;
        public int MatchScore { get; set; }
    }
}
