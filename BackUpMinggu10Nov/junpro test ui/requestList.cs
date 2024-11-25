using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using System.Configuration; // Import namespace untuk ConfigurationManager

namespace junpro_test_ui
{
    public partial class requestList : Form
    {
        public requestList()
        {
            InitializeComponent();

            // Set button properties to make it transparent
            button1.FlatStyle = FlatStyle.Flat;         // Set flat style
            button1.FlatAppearance.BorderSize = 0;      // Remove button border
            button1.BackColor = Color.Transparent;      // Set background color to transparent
            button1.ForeColor = Color.Black;            // Optional: Set text color

            LoadData(); // Call LoadData to populate the DataGridView on form load
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestAcc form5 = new requestAcc();
            form5.Show();
            this.Close();
        }

        private DataGridViewRow selectedRow; // Menyimpan baris yang dipilih

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadData()
        {
            // Retrieve connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query untuk mendapatkan request yang hanya dibuat oleh giver yang sedang login
                    string query = "SELECT * FROM request WHERE giver = @giver";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Tambahkan parameter giver dengan username dari sesi login
                        command.Parameters.AddWithValue("@giver", Program.UserSession.LoggedInUsername);

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // Set DataGridView DataSource

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Periksa jika baris yang valid diklik
            {
                // Ambil baris yang dipilih
                selectedRow = dataGridView1.Rows[e.RowIndex]; // Simpan baris yang dipilih

                // Memberi umpan balik visual jika diperlukan (opsional)
                dataGridView1.ClearSelection(); // Menghapus semua seleksi
                selectedRow.Selected = true; // Menandai baris yang dipilih
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // Buat instance dari form requestAcc
                requestAcc formAcc = new requestAcc();

                // Isi data dari baris yang dipilih ke dalam form requestAcc
                formAcc.ProductName = selectedRow.Cells["product_name"].Value.ToString();
                formAcc.Receiver = selectedRow.Cells["receiver"].Value.ToString();
                formAcc.Slot = selectedRow.Cells["slot"].Value.ToString();
                formAcc.RequestedDate = selectedRow.Cells["requested_date"].Value.ToString();

                // Tampilkan form requestAcc
                formAcc.Show();
                this.Hide(); // Sembunyikan form requestList
            }
            else
            {
                MessageBox.Show("Silakan pilih request terlebih dahulu.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this request?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string requestId = selectedRow.Cells["id"].Value.ToString();

                    using (NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM request WHERE id = @id";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", int.Parse(requestId));
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show("Request deleted successfully.");
                    LoadData(); // Refresh the data grid after deletion
                }
            }
            else
            {
                MessageBox.Show("Please select a request to delete.");
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard form10 = new dashboard();
            form10.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            productPemberi form9 = new productPemberi();
            form9.Show();
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleListReceiver form14 = new ScheduleListReceiver();
            form14.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting form15 = new ViewgeneralSetting();
            form15.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Begin form8 = new Begin();
            form8.Show();
            this.Close();
        }
    }
}
