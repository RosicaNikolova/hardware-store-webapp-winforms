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
        [BindProperty]
        public PreferedShift PreferedShift { get; set; }
        Leave_Preference_RequestManager leaveRequestManager = new Leave_Preference_RequestManager();
        public string MessageLeave { get; set; }
        public string MessagePreference { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPostLEAVEREQUEST() {
            
            try
            {
                int employeeId = Convert.ToInt32(User.FindFirst("id").Value);
                leaveRequestManager.sendRequest(employeeId, LeaveRequest.RequestedDate);
                MessageLeave = "Succesfully requested!";
                return Page();
            }
            catch (Exception error) {
                MessageLeave = error.Message;
                return Page();
            }
        }
        public IActionResult OnPostPREFERENCEREQUEST()
        {
            //need to be finished
            try
            {
                int employeeId = Convert.ToInt32(User.FindFirst("id").Value);
                leaveRequestManager.AddPreferenceRequest(employeeId, PreferedShift.RequestedDate);
                MessagePreference = "Succesfully requested!";
                return Page();
            }
            catch (Exception error)
            {
                MessagePreference = error.Message;
                return Page();
                
            }
        }
    }
}
