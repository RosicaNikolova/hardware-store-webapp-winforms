using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarLibrary.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class ChangePasswordModel : PageModel
    {

        [BindProperty]
        public User user { get; set; }

        EmployeeManager employeeManager = new EmployeeManager();
    

        public void OnGet()
        {
            user = new User();
            int employeeId = Convert.ToInt32(User.FindFirst("id").Value);
            string password = employeeManager.GetPassword(employeeId);
            user.Password = password;
        }
        public IActionResult OnPost()
        {
            if (user.Password != string.Empty)
            {
                int employeeId = Convert.ToInt32(User.FindFirst("id").Value);
                employeeManager.SavePassword(user.Password, employeeId);
                return new RedirectToPageResult("HomePage");
            } 
            else
            {
                ViewData["errorMessage"] = "Password should be at least 9 characters long. It should contain at least one digit.";
                return Page();
            }
        }
    }
}
