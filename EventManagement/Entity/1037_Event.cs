using System.ComponentModel.DataAnnotations;

namespace EventManagement.Entity
{
    public class _1037_Event
    {
        [Key]
         public int id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsCanceled { get; set; }
        public int VenueId { get; set; } 
        public string? Notes { get; set; }
    }
}
