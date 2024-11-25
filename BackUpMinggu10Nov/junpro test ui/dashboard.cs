using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;
using Npgsql;
using System.Data.SqlClient;
using System.Configuration;


namespace junpro_test_ui
{
    public partial class dashboard : Form
    {
        private string _connectionString;
        public dashboard()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleListReceiver form4 = new ScheduleListReceiver();
            form4.Show();
            this.Close();
        }

        private void productPemberi_Click(object sender, EventArgs e)
        {
            productPemberi form9 = new productPemberi();
            form9.Show();
            this.Close();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string loggedInUsername = UserSession.LoggedInUsername;

            // Query untuk mendapatkan data jumlah produk, request, dan penerima
            string queryTotalProduct = @"
                SELECT COUNT(*) 
                FROM product 
                WHERE giver = @username";

            string queryTotalRequest = @"
                SELECT COUNT(*) 
                FROM request 
                WHERE giver = @username";

            string queryTotalReceiver = @"
                SELECT COUNT(*) 
                FROM receiver 
                WHERE giver = @username";

            // Ambil data dari database
            int totalProduct = GetCountFromDatabase(queryTotalProduct, loggedInUsername);
            int totalRequest = GetCountFromDatabase(queryTotalRequest, loggedInUsername);
            int totalReceiver = GetCountFromDatabase(queryTotalReceiver, loggedInUsername);

            // Tampilkan hasil ke label
            lblTotProduct.Text = totalProduct.ToString();
            lblTotRequest.Text = totalRequest.ToString();
            lblTotReceived.Text = totalReceiver.ToString();

            // Load data receiver ke DataGridView
            LoadReceiverData(loggedInUsername);
        }

        private void LoadReceiverData(string giver)
        {
            string query = @"
                SELECT 
                    product_name AS ""Product Name"", 
                    receiver AS ""Receiver Name"", 
                    pickup_date AS ""Schedule"", 
                    slot AS ""Quantities"" 
                FROM public.receiver
                WHERE giver = @giver";

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("giver", giver);

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set DataGridView DataSource
                            dataGVRecentReceiver.DataSource = dataTable;

                            // Konfigurasi tampilan DataGridView
                            ConfigureDataGridViewAppearance();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading receiver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridViewAppearance()
        {
            // Sembunyikan header kolom
            dataGVRecentReceiver.ColumnHeadersVisible = false;

            // Atur lebar setiap kolom
            foreach (DataGridViewColumn column in dataGVRecentReceiver.Columns)
            {
                column.Width = 300; // Atur lebar kolom menjadi 300 piksel
            }

            // Perkecil kolom pointer (Row Header)
            dataGVRecentReceiver.RowHeadersWidth = 20; // Atur lebar kolom pointer lebih kecil

            // Tambahkan properti estetika tambahan jika diperlukan
            dataGVRecentReceiver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGVRecentReceiver.AllowUserToResizeColumns = false; // Disable resizing
            dataGVRecentReceiver.AllowUserToResizeRows = false; // Disable resizing rows
        }


        private void btngeneralSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting settingsForm = new ViewgeneralSetting(Program.UserSession.LoggedInUsername);
            settingsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            requestList form15 = new requestList();
            form15.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Begin form8 = new Begin();
            form8.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Announcement Ann = new Announcement();
            Ann.Show();
            this.Close();
        }

        private void lblTotProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblTotRequest_Click(object sender, EventArgs e)
        {

        }

        private void lblTotReceived_Click(object sender, EventArgs e)
        {

        }

        private int GetCountFromDatabase(string query, string username)
        {
            int count = 0; // Deklarasi hanya satu kali

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return count;
        }

        private void dataGVRecentReceiver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
