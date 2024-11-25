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
    public partial class EditgeneralSetting : Form
    {
        public EditgeneralSetting()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Ambil data dari textbox
            string currentUsername = tbusername.Text;
            string currentPassword = tbcurrent_password.Text;
            string newUsername = tbusername.Text;
            string newPassword = tbnew_password.Text;
            string email = tbemail.Text;
            string location = tblocation.Text;
            string aboutMe = tbabout_me.Text;

            // Buat instance DatabaseHelper
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Lakukan update profile dengan menambahkan token
            bool updateSuccess = dbHelper.UpdateProfile(currentUsername, currentPassword, newUsername, newPassword, email, location, aboutMe);

            if (updateSuccess)
            {
                MessageBox.Show("Profile berhasil diperbarui.");
            }
            else
            {
                MessageBox.Show("Gagal dan silahkan isi data dengan benar");
            }
        }
    }
}
