using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AssistanceRequest
    {
        [Key]
        public int RequestId { get; set; } 
        public int CitizenId { get; set; }
        public string Category { get; set; }
        public string UrgencyLevel { get; set; } 
        public int RequestedQuantity { get; set; }
        public int AssignedQuantity { get; set; }
        public string Status { get; set; } 
        public DateTime RequestDate { get; set; }
    }
}
