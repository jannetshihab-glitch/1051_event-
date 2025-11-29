using System.ComponentModel.DataAnnotations;

namespace EventManagement.Entity
{
    public class _1037_Attendee
    {   
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public int EventId { get; set; }
        public bool IsCheckedIn { get; set; }
    }
}
