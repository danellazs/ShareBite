using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;

namespace junpro_test_ui
{
    public partial class Inbox : Form
    {
        private string _connectionString;
        public Inbox()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            // Set up ListView properties
            listViewNotifications.View = View.Details;
            listViewNotifications.FullRowSelect = true;
            listViewNotifications.GridLines = true;
            listViewNotifications.CheckBoxes = true; // Enable checkboxes for multi-selection

            // Add columns to ListView
            listViewNotifications.Columns.Add("Sender", 100, HorizontalAlignment.Left);
            listViewNotifications.Columns.Add("Content", 300, HorizontalAlignment.Left);
            listViewNotifications.Columns.Add("Date/Time", 150, HorizontalAlignment.Left);


            LoadNotifications();
        }

        public class NotificationTag
        {
            public int Id { get; set; }
            public string Status { get; set; }
        }

        private void LoadNotifications()
        {
            listViewNotifications.Items.Clear();
            int currentUserId = GetCurrentUserId(); // Get the current logged-in user's ID

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                a.username, 
                announcement.content, 
                announcement.created_at, 
                notifications.status, 
                notifications.id 
            FROM notifications
            INNER JOIN announcement ON notifications.announcement_id = announcement.id
            INNER JOIN akun a ON announcement.pemberi_id = a.id
            WHERE notifications.penerima_id = @currentUserId
            ORDER BY announcement.created_at DESC"; // Filter by current user and sort by date

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("currentUserId", currentUserId); // Bind current user ID

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new ListViewItem for each notification
                            var item = new ListViewItem
                            {
                                Text = reader["username"].ToString(), // Display username from akun table as the sender
                                Tag = new NotificationTag
                                {
                                    Id = (int)reader["id"],
                                    Status = reader["status"].ToString()
                                } // Use NotificationTag to manage Id and Status
                            };

                            // Add sub-items
                            item.SubItems.Add(reader["content"].ToString()); // Content

                            // Format Date/Time
                            DateTime createdAt = (DateTime)reader["created_at"];
                            string displayDate = createdAt.Date == DateTime.Today
                                ? createdAt.ToString("hh:mm tt")
                                : createdAt.ToString("dd MMM yyyy");
                            item.SubItems.Add(displayDate); // Date/Time

                            // Color based on read/unread status
                            string status = reader["status"].ToString();
                            item.BackColor = status == "unread" ? Color.LightYellow : Color.White;

                            item.Checked = false; // Initialize checkboxes as unchecked

                            listViewNotifications.Items.Add(item);
                        }
                    }
                }
            }
            UpdateUnreadIndicator();
        }



        // Placeholder for retrieving the current penerima_id
        private int GetCurrentUserId()
        {
            int userId = 0;

            string loggedInUsername = UserSession.LoggedInUsername;  // Mengambil username dari UserSession

            if (!string.IsNullOrEmpty(loggedInUsername))
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Query untuk mencari ID pengguna berdasarkan username
                        string query = "SELECT id FROM public.akun WHERE username = @username LIMIT 1";

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("username", loggedInUsername);

                            var result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                userId = Convert.ToInt32(result);
                            }
                            else
                            {
                                Console.WriteLine("User not found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving user ID: {ex.Message}");
                    }
                }
            }

            return userId;
        }



        private void UpdateUnreadIndicator()
        {
            // Count unread notifications
            int unreadCount = 0;
            foreach (ListViewItem item in listViewNotifications.Items)
            {
                dynamic tag = item.Tag;
                if (tag.Status == "unread")
                {
                    unreadCount++;
                }
            }

            // Update the Label indicator visibility based on unread count
            lblNotifUnread.Visible = unreadCount > 0;
            lblNotifUnread.Text = unreadCount > 0 ? "." : string.Empty; // Display "." if there are unread notifications
            lblNotifUnread.ForeColor = Color.Red; // Set the color of the label to red
        }





        public void SendNotificationToFollowers(int pemberiId, int announcementId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Get the list of follower IDs for the given pemberiId
                    List<int> followerIds = GetFollowers(pemberiId); // Perbaikan: hanya pemberiId yang dikirim

                    // Insert notifications for each follower
                    InsertNotifications(conn, followerIds, announcementId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending notifications: {ex.Message}");
            }
        }

        // Get the follower IDs of a pemberi
        public List<int> GetFollowers(int pemberiId) // Perbaikan: menerima hanya pemberiId
        {
            List<int> followerIds = new List<int>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT follower_id FROM following WHERE followed_id = @pemberiId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("pemberiId", pemberiId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            followerIds.Add(reader.GetInt32(0));
                        }
                    }
                }
            }

            return followerIds;
        }



        // Insert notifications into the notifications table
        private void InsertNotifications(NpgsqlConnection conn, List<int> followerIds, int announcementId)
        {
            using (var transaction = conn.BeginTransaction())
            {
                foreach (var followerId in followerIds)
                {
                    CreateNotification(conn, followerId, announcementId);
                }

                transaction.Commit();
            }
        }

        // Create a notification for a specific follower
        private void CreateNotification(NpgsqlConnection conn, int followerId, int announcementId)
        {
            using (var cmd = new NpgsqlCommand("INSERT INTO notifications (penerima_id, announcement_id) VALUES (@followerId, @announcementId)", conn))
            {
                cmd.Parameters.AddWithValue("followerId", followerId);
                cmd.Parameters.AddWithValue("announcementId", announcementId);

                cmd.ExecuteNonQuery();
            }
        }

        private void listViewNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReadMsg_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                foreach (ListViewItem item in listViewNotifications.CheckedItems)
                {
                    dynamic tag = item.Tag;
                    if (tag.Status == "unread")
                    {
                        var cmd = new NpgsqlCommand("UPDATE notifications SET status = 'read' WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("id", tag.Id);
                        cmd.ExecuteNonQuery();

                        item.BackColor = Color.White; // Change color for read notifications
                        item.Tag = new { Id = tag.Id, Status = "read" }; // Update Tag to reflect the new status
                    }
                }
            }
            UpdateUnreadIndicator();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                foreach (ListViewItem item in listViewNotifications.CheckedItems)
                {
                    dynamic tag = item.Tag;
                    var cmd = new NpgsqlCommand("DELETE FROM notifications WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("id", tag.Id);
                    cmd.ExecuteNonQuery();
                    listViewNotifications.Items.Remove(item); // Remove item from ListView
                }
            }
            UpdateUnreadIndicator();
        }

        private void Inbox_Load(object sender, EventArgs e)
        {

        }
    }
}
