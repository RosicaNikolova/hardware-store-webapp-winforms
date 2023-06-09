using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;


namespace MediaBazaarWebsite.Pages
{
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.SignOutAsync();

            return RedirectToPage("/Index");
        }
    }
}
