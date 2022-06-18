using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class AnnouncementRepository
    {
        public void AddAnnouncement(string announcementContent, string announcementSubject)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "INSERT INTO announcements (announcementContent, announcementSubject, announcementDate) VALUES (@announcementContent, @announcementSubject, @announcementDate)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("announcementContent", announcementContent);
                    cmd.Parameters.AddWithValue("announcementSubject", announcementSubject);
                    cmd.Parameters.AddWithValue("announcementDate", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch {
                throw new Exception();
            }
        }

        public void EditAnnouncement(Announcement announcement)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "UPDATE announcements SET announcementContent = @announcementContent, announcementSubject = @announcementSubject WHERE announcementId = @announcementId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("announcementContent", announcement.AnnouncementContent);
                cmd.Parameters.AddWithValue("announcementSubject", announcement.AnnouncementSubject);
                cmd.Parameters.AddWithValue("announcementId", announcement.AnnouncementId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAnnouncement(Announcement announcement)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "DELETE FROM announcements WHERE announcementId = @announcementId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("announcementId", announcement.AnnouncementId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Announcement GetAnnouncementById(int id)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM announcements WHERE announcementId = @announcementId";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("announcementId", id);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                Announcement announcement = null;
                while (dr.Read())
                {
                    announcement = new Announcement();
                    announcement.AnnouncementId = dr.GetInt32("announcementId");
                    announcement.AnnouncementContent = dr.GetString("announcementContent");
                    announcement.AnnouncementSubject = dr.GetString("announcementSubject");
                    announcement.AnnouncementDate = dr.GetDateTime("announcementDate");
                }

                return announcement;
            }
        }

        public List<Announcement> GetAnnouncements()
        {
            List<Announcement> announcements = new List<Announcement>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "SELECT * FROM announcements";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                Announcement announcement = null;
                while (dr.Read())
                {
                    announcement = new Announcement();
                    announcement.AnnouncementId = dr.GetInt32("announcementId");
                    announcement.AnnouncementContent = dr.GetString("announcementContent");
                    announcement.AnnouncementSubject = dr.GetString("announcementSubject");
                    announcement.AnnouncementDate = dr.GetDateTime("announcementDate");
                    announcements.Add(announcement);
                }
            }

            return announcements;
        }
    }
}
