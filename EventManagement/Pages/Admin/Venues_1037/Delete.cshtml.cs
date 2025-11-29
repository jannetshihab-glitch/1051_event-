using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Venues_1037
{
    public class DeleteModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public DeleteModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public _1037_Venue _1037_Venue { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _1037_venue = await _context._1037_Venue.FirstOrDefaultAsync(m => m.Id == id);

            if (_1037_venue is not null)
            {
                _1037_Venue = _1037_venue;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _1037_venue = await _context._1037_Venue.FindAsync(id);
            if (_1037_venue != null)
            {
                _1037_Venue = _1037_venue;
                _context._1037_Venue.Remove(_1037_Venue);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
