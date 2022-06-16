using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }

        public string AnnouncementContent { get; set; }

        public DateTime AnnouncementDate { get; set; }

        public Announcement()
        {

        }

        public Announcement(string announcementContent, DateTime announcementDate)
        {
            this.AnnouncementContent = announcementContent;
            this.AnnouncementDate = announcementDate;
        }
    }
}
