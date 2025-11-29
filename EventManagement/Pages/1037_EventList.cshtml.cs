using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManagement.Pages
{
    public class _1037_EventListModel : PageModel
    {
        public List<string> MockEvents { get; set; } = new List<string>();
        public void OnGet()
        {
            MockEvents = new List<string>
            {
                "Tech Conference 2024",
                "Music Festival",
                "Business Workshop"
            };
        }
    }
}
