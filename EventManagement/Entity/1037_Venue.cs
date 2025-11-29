using System.ComponentModel.DataAnnotations;

namespace EventManagement.Entity
{
    public class _1037_Venue
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool HasParking { get; set; }
        public string? ContactEmail { get; set; }
    }
}
