using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Events_1037
{
    public class IndexModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public IndexModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<_1037_Event> _1037_Event { get;set; } = default!;

        public async Task OnGetAsync()
        {
            _1037_Event = await _context._1037_Events.ToListAsync();
        }
    }
}
