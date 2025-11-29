using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Venues_1037
{
    public class EditModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public EditModel(EventManagement.Data.ApplicationDbContext context)
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

            var _1037_venue =  await _context._1037_Venue.FirstOrDefaultAsync(m => m.Id == id);
            if (_1037_venue == null)
            {
                return NotFound();
            }
            _1037_Venue = _1037_venue;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(_1037_Venue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_1037_VenueExists(_1037_Venue.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool _1037_VenueExists(int id)
        {
            return _context._1037_Venue.Any(e => e.Id == id);
        }
    }
}
