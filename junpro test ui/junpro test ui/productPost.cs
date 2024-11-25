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
    public partial class productPost : Form
    {
        public productPost()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Contoh penyesuaian pada event handler
        private void btnInsert_Click(object sender, EventArgs e)
        {/*
            // Ambil data dari input
            var productItem = new ProductItem(
                "",
                txtNameProduct.Text,
                txtDescriptionProduct.Text,
                txtImagePathProduct.Text,
                int.TryParse(txtStockProduct.Text, out int stock) ? stock : 0, // Validasi stok
                dtpExpiredDateProduct.Value
            );

            var dbHelper = new DatabaseHelper();
            int result = dbHelper.InsertProduct(productItem);

            if (result == 1)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("Data insertion failed.");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPemberi form14 = new productPemberi();
            form14.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}