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
    public partial class ViewgeneralSetting : Form
    {
        public ViewgeneralSetting()
        {
            InitializeComponent();
        }


        public ViewgeneralSetting(string username) // Terima username sebagai parameter
        {
            InitializeComponent();

            // Buat instance DatabaseHelper
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Ambil data profil berdasarkan username
            var profileData = dbHelper.GetUserProfile(username);

            if (profileData.email != null) // Jika data berhasil diambil
            {
                // Tampilkan data di textbox
                tbusername.Text = username;
                tbemail.Text = profileData.email;
                tblocation.Text = profileData.location;
                tbabout_me.Text = profileData.aboutMe;
            }
            else
            {
                MessageBox.Show("Data profil tidak ditemukan.");
            }
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            EditgeneralSetting form2 = new EditgeneralSetting();

            // Menampilkan Form2
            form2.Show();

            // Menutup Form1 sepenuhnya
            this.Close();
        }
    }
}
