using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Entity;
using Microsoft.AspNetCore.Authorization;

namespace EventManagement.Pages.Admin
{   
    
    public class IndexModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public IndexModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<_1037_Attendee> _1037_Attendee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            _1037_Attendee = await _context._1037_Attendees.ToListAsync();
        }
    }
}
