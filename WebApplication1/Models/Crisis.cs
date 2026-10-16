namespace WebApplication1.Models
{
    public class Crisis
    {
        public int Id { get; set; }
        public string CrisisName { get; set; } = string.Empty; 
        public string Location { get; set; } = string.Empty;
        public int AffectedPeople { get; set; }
        public string Severity { get; set; } = string.Empty; 
        public string Status { get; set; } = string.Empty; 
        public DateTime StartedDate { get; set; }
    }
}
