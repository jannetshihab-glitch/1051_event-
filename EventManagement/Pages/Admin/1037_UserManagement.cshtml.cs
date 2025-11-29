using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManagement.Pages.Admin
{
    public class _1037_UserManagementModel : PageModel
    {   
        [Authorize]
        public void OnGet()
        {
        }
    }
}
