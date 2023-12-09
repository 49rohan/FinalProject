using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Lanes
    {
        [Key]// LaneID is primary key
        public int LaneID {  get; set; }
        // Lane for the champs
        public string? Lane {  get; set; }

    }
}
