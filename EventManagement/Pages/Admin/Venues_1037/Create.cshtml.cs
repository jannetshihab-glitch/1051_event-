using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventManagement.Data;
using EventManagement.Entity;

namespace EventManagement.Pages.Admin.Venues_1037
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
        public _1037_Venue _1037_Venue { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context._1037_Venue.Add(_1037_Venue);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
