namespace WebApplication1.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }
        public string ShelterName { get; set; }
        public string Location { get; set; }
        public string District { get; set; }
        public int Capacity { get; set; }
        public int Occupied { get; set; }
        public string Status { get; set; } = string.Empty;
        public bool Accessibility { get; set; }
    }
}
