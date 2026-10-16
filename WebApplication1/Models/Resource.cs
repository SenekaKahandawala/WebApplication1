using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public string Location { get; set; }
    }
}
