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
    public partial class ScheduleDate : Form
    {
        private DatabaseHelper dbHelper; // Deklarasikan dbHelper sebagai variabel anggota
        private int id;
        private string receiverName;
        private string productName;
        private int slot;
        public ScheduleDate(int id, string receiverName, string productName, int slot)
        {
            dbHelper = new DatabaseHelper();

            InitializeComponent();
            // Simpan parameter yang diterima ke variabel
            this.id = id;
            this.receiverName = receiverName;
            this.productName = productName;
            this.slot = slot;

            // Menampilkan nilai di label
            lblReceiver.Text = receiverName;
            lblProductName.Text = productName;
            lblQty.Text = slot.ToString();

            MessageBox.Show("ID yang diterima: " + id);
        }

        private void ScheduleDate_Load(object sender, EventArgs e)
        {
            // Tampilkan data yang sudah diterima di label-label
            lblReceiver.Text = receiverName;
            lblProductName.Text = productName;
            lblQty.Text = slot.ToString();
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = EditPickupDate.SelectionStart;
                bool isUpdated = dbHelper.UpdatePickupDate(id, selectedDate);

                if (isUpdated)
                {
                    MessageBox.Show("Tanggal pickup berhasil diupdate.");
                }
                else
                {
                    MessageBox.Show("Gagal mengupdate tanggal pickup.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error di btnSetDate_Click: " + ex.Message);
            }
        }
    }
}
