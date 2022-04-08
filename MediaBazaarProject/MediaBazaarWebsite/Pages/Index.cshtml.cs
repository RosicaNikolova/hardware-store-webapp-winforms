using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarLibrary.Business;
using MediaBazaarLibrary;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace MediaBazaarWebsite.Pages
{

    public class IndexModel : PageModel
    {


        [BindProperty]
        public User user { get; set; }
       
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(string? returnUrl)
        {
            LoginManager loginManager = new LoginManager();
            try
            {
                if (ModelState.IsValid)
                {
                    User loggingUser = null;
                    loggingUser = loginManager.Login(user.Email, user.Password);
                    if (loggingUser != null)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Role, loggingUser.Position.ToString()));
                        claims.Add(new Claim("id", user.Id.ToString()));

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    }
                    else
                    {
                        throw new Exception("Invalid credentials");
                    }

                }
                if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToPage("HomePage");
                }
            }
            catch (Exception error)
            {
                ViewData["errorMessage"] = error.Message;
                return Page();
            }
        }
    }
}

