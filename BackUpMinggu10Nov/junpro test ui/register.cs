using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BCrypt.Net;

namespace junpro_test_ui
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            login form2 = new login();
            dashboard form3 = new dashboard();
            this.Hide();
            form2.Show();
            form3.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Membuat instance DatabaseHelper
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Ambil data dari input user
            string email = tbemail.Text;
            string nomorHp = tbnomortelephone.Text;
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string role;

            if (rbpemberi.Checked)
            {
                role = "pemberi";
            }
            else if (rbpenerima.Checked)
            {
                role = "penerima";
            }
            else
            {
                MessageBox.Show("Silakan pilih role Anda sebagai pemberi atau penerima.");
                return; // Menghentikan eksekusi jika belum ada pilihan
            }

            // Validasi input sederhana
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nomorHp) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            // Hash password sebelum disimpan
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Cek apakah username sudah ada menggunakan token
            if (!dbHelper.IsUsernameAvailable(username))
            {
                MessageBox.Show("Username sudah ada. Silakan login.");
                return;
            }

            // Jika username belum ada, simpan data ke database
            dbHelper.RegisterUser(email, nomorHp, username, hashedPassword, role);
            MessageBox.Show("Registrasi berhasil! Silakan login.");

            // Redirect ke halaman login
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbpenerima_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
