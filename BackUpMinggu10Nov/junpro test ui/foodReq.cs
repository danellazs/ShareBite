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
    public partial class foodReq : Form
    {
        private string selectedProductId;
        public foodReq(string productId)
        {
            InitializeComponent();
            selectedProductId = productId;
        }
        private void LoadProductDetails()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            ProductItem product = dbHelper.GetProductById(selectedProductId);

            if (product != null)
            {
                lblProductName.Text = product.Name;
                lblStock.Text = "Stock: " + product.Stock;
                pictureBox.Image = Image.FromFile(product.ImagePath); // Pastikan path image benar
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        public foodReq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int slot;
            if (!int.TryParse(tbQty.Text, out slot))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            DateTime requestDate = dateTimePicker.Value;

            // Ambil informasi produk yang sedang ditampilkan
            DatabaseHelper dbHelper = new DatabaseHelper();
            ProductItem product = dbHelper.GetProductById(selectedProductId);

            if (product != null)
            {
                string productName = product.Name;
                string giver = product.Giver;
                string receiver = Program.UserSession.LoggedInUsername; // Ambil receiver dari session login

                // Simpan request
                dbHelper.InsertRequest(productName, giver, receiver, slot, requestDate);
                MessageBox.Show("Request sent successfully.");
            }
            else
            {
                MessageBox.Show("Failed to retrieve product information.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void foodReq_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            // Isi dengan logika yang diinginkan ketika lblStock diklik
            MessageBox.Show("Stock label clicked");
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            // Isi dengan logika yang diinginkan ketika lblProductName diklik
            MessageBox.Show("Product name label clicked");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // Isi dengan logika yang diinginkan ketika pictureBox diklik
            MessageBox.Show("Picture box clicked");
        }

    }
}