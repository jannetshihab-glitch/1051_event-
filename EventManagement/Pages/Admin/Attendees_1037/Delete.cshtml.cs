using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Attendees_1037
{
    public class DeleteModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public DeleteModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public _1037_Attendee _1037_Attendee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _1037_attendee = await _context._1037_Attendees.FirstOrDefaultAsync(m => m.Id == id);

            if (_1037_attendee is not null)
            {
                _1037_Attendee = _1037_attendee;

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

            var _1037_attendee = await _context._1037_Attendees.FindAsync(id);
            if (_1037_attendee != null)
            {
                _1037_Attendee = _1037_attendee;
                _context._1037_Attendees.Remove(_1037_Attendee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
