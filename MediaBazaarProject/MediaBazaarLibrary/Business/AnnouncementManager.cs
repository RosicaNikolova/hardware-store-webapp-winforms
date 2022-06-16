using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class AnnouncementManager
    {
        public AnnouncementRepository announcementRepository = new AnnouncementRepository();

        public void AddAnnouncement(string announcementContent)
        {
            announcementRepository.AddAnnouncement(announcementContent);
        }

        public void EditAnnouncement(Announcement announcement)
        {
            announcementRepository.EditAnnouncement(announcement);
        }

        public void DeleteAnnouncement(Announcement announcement)
        {
            announcementRepository.DeleteAnnouncement(announcement);
        }

        public Announcement GetAnnouncementById(int id)
        {
            return announcementRepository.GetAnnouncementById(id);
        }

        public List<Announcement> GetAnnouncements()
        {
            return announcementRepository.GetAnnouncements();
        }
    }
}
