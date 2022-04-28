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
    public class LeaveRequestPageModel : PageModel
    {
        [BindProperty]
        public LeaveRequest LeaveRequest { get; set; }
        LeaveRequestManager leaveRequestManager = new LeaveRequestManager();
        public void OnGet()
        {
        }
        public void OnPost() {
            //will finish this method tonight
            int employeeId = Convert.ToInt32(User.FindFirst("id").Value);
            leaveRequestManager.sendRequest(employeeId, LeaveRequest.RequestedDate);
        }
    }
}
