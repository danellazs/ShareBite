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

namespace junpro_test_ui
{
    public partial class requestAcc : Form
    {
        public string ProductName { get; set; }
        public string Receiver { get; set; }
        public string Slot { get; set; }
        public string RequestedDate { get; set; }


        public requestAcc()
        {
            InitializeComponent();
        }

        private void requestAcc_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Request has been sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void requestAcc_Load(object sender, EventArgs e)
        {
            // Isi TextBox dengan data yang diterima
            tbProduct.Text = ProductName;
            tbReceiver.Text = Receiver;
            tbSlot.Text = Slot;
            tbRequestedDate.Text = RequestedDate;
        }

        private void tbGiver_Click(object sender, EventArgs e)
        {

        }

        private void tbSlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReceiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRequestedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void pickupDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in as: " + Program.UserSession.LoggedInUsername);

            string place = tbPlace.Text;
            DateTime pickUpDate = pickupDate.SelectionStart;

            if (string.IsNullOrWhiteSpace(place) || string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(Receiver) || string.IsNullOrWhiteSpace(Slot))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            DatabaseHelper dbHelper = new DatabaseHelper();

            if (dbHelper.IsUserGiver(Program.UserSession.LoggedInUsername))
            {
                dbHelper.SaveApprovedRequest(ProductName, Program.UserSession.LoggedInUsername, Receiver, Convert.ToInt32(Slot), place, pickUpDate);

                DialogResult result = MessageBox.Show("Request disetujui dan telah dihapus dari daftar request.", "Konfirmasi", MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {
                    requestList formA = new requestList();
                    formA.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki izin untuk menyetujui request ini.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            requestList form6 = new requestList();
            form6.Show();
            this.Close();
        }
    }
}