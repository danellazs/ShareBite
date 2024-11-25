using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;
using static System.Windows.Forms.DataFormats;
using Newtonsoft.Json;

namespace junpro_test_ui
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Giver giver = new Giver (tbemail.Text, tbpassword.Text);
            if (giver.LoginGiver(giver.Email, giver.Password))
            {
                dashboard form3 = new dashboard();
                form3.Show();
                this.Close();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void create_account_Click(object sender, EventArgs e)
        {
            register form2 = new register();

            // Menampilkan Form2
            form2.Show();

            // Menutup Form1 sepenuhnya
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Ambil data dari textbox
            string username = tbusername.Text;
            string password = tbpassword.Text;

            // Membuat instance dari DatabaseHelper
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Lakukan proses login
            string loginResult = dbHelper.LoginUser(username, password);

            if (loginResult == "pemberi")
            {
                UserSession.LoggedInUsername = username;

                // Jika role adalah pemberi, arahkan ke dashboard
                dashboard dashboardForm = new dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else if (loginResult == "penerima")
            {
                UserSession.LoggedInUsername = username;
                // Jika role adalah penerima, arahkan ke product
                product productForm = new product();
                productForm.Show();
                this.Hide();
            }
            else if (loginResult == "wrong_password")
            {
                // Jika password salah
                MessageBox.Show("Password salah. Silakan coba lagi.");
            }
            else if (loginResult == "not_found")
            {
                // Jika username tidak ditemukan
                MessageBox.Show("Akun tidak ditemukan, silakan registrasi.");
            }


        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
