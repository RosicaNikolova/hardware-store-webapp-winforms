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
    public class HomePageModel : PageModel
    {
        [BindProperty]
        public Announcement announcement { get; set; }
        public AnnouncementManager announcementManager = new AnnouncementManager();
        public void OnGet()
        {
        }
    }
}
