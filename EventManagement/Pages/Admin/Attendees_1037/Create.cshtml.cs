using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Attendees_1037
{
    public class CreateModel : PageModel
    {
        private readonly EventManagement.Data.ApplicationDbContext _context;

        public CreateModel(EventManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public _1037_Attendee _1037_Attendee { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context._1037_Attendees.Add(_1037_Attendee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
