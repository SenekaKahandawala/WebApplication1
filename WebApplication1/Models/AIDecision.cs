using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AIDecision
    {
        [Key]
        public int DecisionId { get; set; } 
        public int RequestId { get; set; } 
        public string AIRecommendation { get; set; } 
        public double ConfidenceScore { get; set; } 
        public string HumanDecision { get; set; }
        public string ReviewedBy { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
    }
}
