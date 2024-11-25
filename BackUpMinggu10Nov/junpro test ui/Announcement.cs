using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;

namespace junpro_test_ui
{
    public partial class Announcement : Form
    {
        private string _connectionString;
        public Announcement()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        // Method to get the current user's ID (this is just a placeholder, you should implement it as per your app logic)
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


        private void btnSendAnnounce_Click(object sender, EventArgs e)
        {

            // Get the current user's ID
            int pemberiId = GetCurrentUserId();

            // Get the content from the textbox
            string content = tbAnnounce.Text.Trim();

            // Check if the content is not empty
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please enter some content for the announcement.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize DatabaseHelper and create the announcement
            DatabaseHelper dbHelper = new DatabaseHelper();

            bool announcementPosted = dbHelper.CreateAnnouncement(pemberiId, content);

            if (announcementPosted)
            {
                MessageBox.Show("Announcement posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAnnounce.Clear();

                // Get the ID of the latest announcement
                int announcementId = dbHelper.GetLatestAnnouncementId(pemberiId); // Pass pemberiId here

                // Get the followers of the current pemberi
                List<int> followers = GetFollowers(pemberiId); // Pass pemberiId here

                // Insert notifications for followers
                InsertNotifications(followers, announcementId); // Pass followers and announcementId here

                // Reload announcements to display the new one
                LoadAnnouncements();
            }
            else
            {
                MessageBox.Show("Failed to post the announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAnnounce_TextChanged(object sender, EventArgs e)
        {

        }
        public void SendNotificationToFollowers(int pemberiId, int announcementId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Get the list of follower IDs for the given pemberiId
                    List<int> followerIds = GetFollowers(pemberiId);

                    // Insert notifications for each follower
                    InsertNotifications(followerIds, announcementId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending notifications: {ex.Message}");
            }
        }

        // Method signature should look like this:
        public void InsertNotifications(List<int> followers, int announcementId)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    foreach (var followerId in followers)
                    {
                        CreateNotification(conn, followerId, announcementId); // Insert notification for each follower
                    }
                    transaction.Commit();
                }
            }
        }

        private void CreateNotification(NpgsqlConnection conn, int followerId, int announcementId)
        {
            string query = "INSERT INTO public.notifications (penerima_id, announcement_id) VALUES (@followerId, @announcementId)";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("followerId", followerId);
                cmd.Parameters.AddWithValue("announcementId", announcementId);
                cmd.ExecuteNonQuery();
            }
        }


        // The method signature should look like this:
        public List<int> GetFollowers(int pemberiId)
        {
            List<int> followers = new List<int>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT follower_id FROM public.following WHERE followed_id = @pemberiId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("pemberiId", pemberiId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            followers.Add(reader.GetInt32(0)); // Add follower_id to the list
                        }
                    }
                }
            }

            return followers;
        }




        private Panel CreateRoundedPanel(string content)
        {
            Panel panel = new Panel
            {
                Width = 300,  // Adjust width as needed
                Height = 50,
                BackColor = Color.White,
                Margin = new Padding(10),
            };

            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Rectangle rect = panel.ClientRectangle;
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 15;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    panel.Region = new Region(path);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.Gray, 1))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            };

            Label label = new Label
            {
                Text = content,
                AutoSize = true,
                Location = new Point(10, 15),
                Font = new Font("Arial", 10, FontStyle.Regular),
            };
            panel.Controls.Add(label);

            return panel;
        }


        private void LoadAnnouncements()
        {
            // Initialize DatabaseHelper and fetch announcements
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<string> announcements = dbHelper.GetAnnouncements(); // Assume GetAnnouncements fetches the announcement content list

            // Clear existing panels (if any)
            flowLPAnnouncement.Controls.Clear();

            // Create and add a panel for each announcement
            foreach (var content in announcements)
            {
                Panel roundedPanel = CreateRoundedPanel(content);
                flowLPAnnouncement.Controls.Add(roundedPanel);
            }
        }


        private void flowLPAnnouncement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Announcement_Load_1(object sender, EventArgs e)
        {
            LoadAnnouncements();
        }
    }
}
