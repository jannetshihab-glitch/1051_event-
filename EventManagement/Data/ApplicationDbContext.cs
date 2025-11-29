using EventManagement.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<_1037_Event> _1037_Events { get; set; }
        public DbSet<_1037_Venue> _1037_Venue { get; set; }
        public DbSet<_1037_Attendee> _1037_Attendees { get; set; }

    }
}
