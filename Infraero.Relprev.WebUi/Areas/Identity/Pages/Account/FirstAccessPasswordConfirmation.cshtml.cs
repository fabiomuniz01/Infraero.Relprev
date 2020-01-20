using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Infraero.Relprev.WebUi.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class FirstAccessPasswordConfirmationModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}