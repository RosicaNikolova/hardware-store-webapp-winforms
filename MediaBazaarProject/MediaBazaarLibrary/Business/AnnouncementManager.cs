using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class AnnouncementManager
    {
        public AnnouncementRepository announcementRepository = new AnnouncementRepository();

        public void AddAnnouncement(string announcementContent, string announcementSubject)
        {
            announcementRepository.AddAnnouncement(announcementContent, announcementSubject); //done
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
        public DataTable GetAllAnnouncements() {
            List<Announcement> announcements = new List<Announcement>();
            announcements = announcementRepository.GetAnnouncements();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Publish date");
            dt.Columns.Add("Subject");
            foreach (Announcement a in announcements) {
                DataRow dr = dt.NewRow();
                dr["ID"] = a.AnnouncementId;
                dr["Publish date"] = a.AnnouncementDate.ToString("dd/MM/yyyy");
                dr["Subject"] = a.AnnouncementSubject;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
