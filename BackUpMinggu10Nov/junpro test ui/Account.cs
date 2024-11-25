namespace junpro_test_ui
{
    public class Account
    {
        // Atribut dengan access modifier private/protected
        private string username;
        private string password; // Password terenkripsi
        protected string email;
        protected string role;

        // Constructor
        public Account(string username, string password, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        // Property untuk mengakses username (read-only)
        public string Username
        {
            get { return username; }
        }

        // Property untuk memverifikasi password
        public bool VerifyPassword(string inputPassword)
        {
            // Memverifikasi password menggunakan BCrypt
            return BCrypt.Net.BCrypt.Verify(inputPassword, password);
        }

        // Property untuk role (read-only)
        public string Role
        {
            get { return role; }
        }

        // Method untuk mengubah password
        public void SetNewPassword(string newPassword)
        {
            password = BCrypt.Net.BCrypt.HashPassword(newPassword);
        }

        // Method untuk login (contoh sederhana)
        public bool Login(string inputUsername, string inputPassword)
        {
            return inputUsername == username && inputPassword == password;
        }
    }
}