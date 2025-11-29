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
    public class DeleteModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public DeleteModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public _1037_Event _1037_Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _1037_event = await _context._1037_Events.FirstOrDefaultAsync(m => m.id == id);

            if (_1037_event is not null)
            {
                _1037_Event = _1037_event;

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

            var _1037_event = await _context._1037_Events.FindAsync(id);
            if (_1037_event != null)
            {
                _1037_Event = _1037_event;
                _context._1037_Events.Remove(_1037_Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
