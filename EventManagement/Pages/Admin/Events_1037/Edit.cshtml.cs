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

namespace EventManagement.Pages.Admin.Events_1037
{
    public class EditModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public EditModel(EventManagement.Data.ApplicationDbContext context)
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

            var _1037_event =  await _context._1037_Events.FirstOrDefaultAsync(m => m.id == id);
            if (_1037_event == null)
            {
                return NotFound();
            }
            _1037_Event = _1037_event;
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

            _context.Attach(_1037_Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_1037_EventExists(_1037_Event.id))
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

        private bool _1037_EventExists(int id)
        {
            return _context._1037_Events.Any(e => e.id == id);
        }
    }
}
