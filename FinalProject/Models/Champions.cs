using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Champions
    {
        [Key]// Primary key is ChampId
        public int ChampId { get; set; }
        // Name for champion
        public string? Name { get; set; }
        // Foreign key for the lanes
        public int LaneID { get; set; }
        public Lanes? Lanes { get; set; }
    }
}
