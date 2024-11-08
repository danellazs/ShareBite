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
                    string query = "SELECT * FROM pengajuanRequest";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Set the DataGridView's DataSource

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
    }
}
