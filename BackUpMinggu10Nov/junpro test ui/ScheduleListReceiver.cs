using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace junpro_test_ui
{
    public partial class ScheduleListReceiver : Form
    {
        private DatabaseHelper dbHelper;
        private DataGridViewRow selectedRow; // Untuk menyimpan baris yang dipilih


        public ScheduleListReceiver()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadData();
        }

        private void LoadData()
        {
            // Ambil username dari session login
            string loggedInGiver = Program.UserSession.LoggedInUsername;


            // Dapatkan daftar penerima dari database sebagai DataTable
            List<ReceiverItem> receivers = dbHelper.GetReceiversByGiver(loggedInGiver);

            // Konversi List ke DataTable
            DataTable dataTable = ConvertToDataTable(receivers);

            // Tampilkan data di DataGridView
            dataGridView1.DataSource = dataTable;

            // Sembunyikan kolom id di DataGridView
            if (dataGridView1.Columns["id"] != null) // Pastikan kolom id ada
            {
                dataGridView1.Columns["id"].Visible = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        private DataTable ConvertToDataTable(List<ReceiverItem> items)
        {
            var dataTable = new DataTable();

            // Menambahkan kolom sesuai dengan properti di `ReceiverItem`
            dataTable.Columns.Add("id", typeof(int)); // pastikan kolom "id" ada
            dataTable.Columns.Add("receiver", typeof(string));
            dataTable.Columns.Add("product_name", typeof(string));
            dataTable.Columns.Add("slot", typeof(int));
            dataTable.Columns.Add("pickup_date", typeof(DateTime));
            dataTable.Columns.Add("place", typeof(string));

            foreach (var item in items)
            {
                dataTable.Rows.Add(item.Id, item.ReceiverName, item.ProductName, item.Slot, item.PickupDate, item.Place);
            }

            return dataTable;
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string receiverName = selectedRow.Cells["receiver"].Value.ToString();
                string productName = selectedRow.Cells["product_name"].Value.ToString();
                int slot = Convert.ToInt32(selectedRow.Cells["slot"].Value);

                // Pastikan ID ditampilkan untuk verifikasi
                MessageBox.Show("ID yang dipilih: " + id);

                // Panggil form ScheduleDate dan kirim data
                ScheduleDate scheduleDateForm = new ScheduleDate(id, receiverName, productName, slot);
                scheduleDateForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silakan pilih data penerima terlebih dahulu.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                // Menyimpan baris yang dipilih ke dalam variabel
                selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }


    }
}
