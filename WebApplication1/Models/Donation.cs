namespace WebApplication1.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string DonationNumber { get; set; } = string.Empty; 
        public string DonorName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; 
        public string ItemsOrAmount { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public string Status { get; set; } = string.Empty; 
        public DateTime ReceivedDate { get; set; }
    }
}
