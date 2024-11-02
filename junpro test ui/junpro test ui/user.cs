using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junpro_test_ui
{
    internal class user
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NomorTelephone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor untuk inisialisasi User
        public user(string email, string nomortelephone, string username, string password)
        {
            Email = email;
            NomorTelephone = nomortelephone;
            Username = username;
            Password = password;
        }

        // Metode untuk memvalidasi inputan
        public bool IsValid()
        {
            // Cek apakah Email valid
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                return false; // Email tidak valid
            }

            /*// Cek apakah PhoneNumber valid
            if (string.IsValidnomorTelephone(NomorTelephone))
            {
                return false; // Nomor telepon tidak valid
            }*/

            // Cek apakah Username valid
            if (string.IsNullOrWhiteSpace(Username))
            {
                return false; // Username tidak boleh kosong
            }

            // Cek apakah Password valid
            if (string.IsNullOrWhiteSpace(Password) || Password.Length < 6)
            {
                return false; // Password harus lebih dari 6 karakter
            }

            return true; // Semua validasi berhasil
        }

        public bool IsValiNomorTelephone(string nomorTelephone)
        {
            // Logika sederhana untuk memvalidasi nomor telepon
            return NomorTelephone.All(char.IsDigit) && NomorTelephone.Length <= 15; // Nomor hanya boleh digit dan maksimal 15 karakter
        }
    }
}
