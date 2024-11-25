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
    public partial class SchedulePenerima : Form
    {
        private string _connectionString;

        public SchedulePenerima()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            // Tambahkan handler untuk event Form Load
            this.Load += SchedulePenerima_Load;

            // Tambahkan tombol refresh
            Button refreshButton = new Button
            {
                Text = "Refresh",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            refreshButton.Click += RefreshButton_Click;
            this.Controls.Add(refreshButton);
        }

        private void SchedulePenerima_Load(object sender, EventArgs e)
        {
            // Atur properti awal untuk DataGridView
            dataGVScheduleDetail.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGVScheduleDetail.DefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGVScheduleDetail.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGVScheduleDetail.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Tampilkan pesan selamat datang kepada pengguna
            MessageBox.Show($"Welcome, {UserSession.LoggedInUsername}! Please select a date to view your schedule.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            // Dapatkan penerima yang sedang login
            string loggedInUsername = UserSession.LoggedInUsername;

            // Ambil tanggal yang dipilih saat ini di MonthCalendar
            DateTime selectedDate = monthCalenderSchedulePicker.SelectionStart;

            // Panggil ulang fungsi untuk memuat detail jadwal
            LoadScheduleDetails(loggedInUsername, selectedDate);
        }

        private void monthCalenderSchedulePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Dapatkan penerima yang sedang login
            string loggedInUsername = UserSession.LoggedInUsername;

            // Ambil tanggal yang dipilih di MonthCalendar
            DateTime selectedDate = monthCalenderSchedulePicker.SelectionStart;

            // Panggil fungsi untuk menampilkan detail schedule berdasarkan penerima dan tanggal
            LoadScheduleDetails(loggedInUsername, selectedDate);
        }

        private void LoadScheduleDetails(string receiverUsername, DateTime selectedDate)
        {
            string query = @"
                SELECT 
                    product_name AS ""Product Name"", 
                    giver AS ""Giver"", 
                    pickup_date AS ""Schedule"", 
                    place AS ""Place"" 
                FROM public.receiver
                WHERE receiver = @receiverUsername AND pickup_date = @selectedDate";

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Tambahkan parameter untuk receiver dan tanggal
                        cmd.Parameters.AddWithValue("receiverUsername", receiverUsername);
                        cmd.Parameters.AddWithValue("selectedDate", selectedDate);

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set DataGridView DataSource untuk menampilkan data
                            dataGVScheduleDetail.DataSource = dataTable;

                            // Konfigurasi tampilan DataGridView
                            ConfigureDataGridViewAppearance();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading schedule details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridViewAppearance()
        {
            // Sembunyikan header kolom
            dataGVScheduleDetail.ColumnHeadersVisible = true; // Ubah ke true untuk menampilkan header kolom

            // Atur lebar setiap kolom
            foreach (DataGridViewColumn column in dataGVScheduleDetail.Columns)
            {
                column.Width = 160; // Atur lebar kolom menjadi 160 piksel
            }

            // Perkecil kolom pointer (Row Header)
            dataGVScheduleDetail.RowHeadersWidth = 20; // Atur lebar kolom pointer lebih kecil

            // Tambahkan properti estetika tambahan jika diperlukan
            dataGVScheduleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolom akan otomatis menyesuaikan
            dataGVScheduleDetail.AllowUserToResizeColumns = false; // Disable resizing
            dataGVScheduleDetail.AllowUserToResizeRows = false; // Disable resizing rows
            dataGVScheduleDetail.BackgroundColor = Color.WhiteSmoke;
            dataGVScheduleDetail.GridColor = Color.LightGray;

            // Tambahkan style alternatif untuk baris
            dataGVScheduleDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void dataGVScheduleDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tambahkan logika tambahan di sini jika diperlukan
        }
    }
}
