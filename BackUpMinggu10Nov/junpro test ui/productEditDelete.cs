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
    public partial class productEditDelete : Form
    {
        private ProductItem _product;

        public productEditDelete(ProductItem product)
        {
            InitializeComponent();
            _product = product;
            LoadProductData();
        }

        private void LoadProductData()
        {
            txtName.Text = _product.Name;
            txtDescription.Text = _product.Description;
            txtImagePath.Text = _product.ImagePath;
            txtStock.Text = _product.Stock.ToString();
            dtpExpiredDate.Value = _product.ExpiredDate;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _product.Name = txtName.Text;
            _product.Description = txtDescription.Text;
            _product.ImagePath = txtImagePath.Text;
            _product.Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0;
            _product.ExpiredDate = dtpExpiredDate.Value;

            var dbHelper = new DatabaseHelper();
            int result = dbHelper.UpdateProduct(_product);

            if (result == 1)
            {
                MessageBox.Show("Data updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Data update failed.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus produk ini?",
                                         "Konfirmasi Hapus",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var dbHelper = new DatabaseHelper();
                int result = dbHelper.DeleteProduct(_product.ID);

                if (result > 0)
                {
                    MessageBox.Show("Produk berhasil dihapus.");
                    this.Close(); // Menutup form setelah penghapusan
                }
                else
                {
                    MessageBox.Show("Gagal menghapus produk. Pastikan produk ada di database."); // Pesan jika gagal
                }
            }
        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPemberi form15 = new productPemberi();
            form15.Show();
            this.Close();
        }

        private void productEditDelete_Load(object sender, EventArgs e)
        {

        }
    }
}