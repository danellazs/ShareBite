using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace junpro_test_ui
{
    public class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }

        /*public int InsertProduct(ProductItem product)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT st_insert(@name, @description, @image, @stock, @expired::date)", connection))
                {
                    command.Parameters.AddWithValue("name", product.Name);
                    command.Parameters.AddWithValue("description", product.Description);
                    command.Parameters.AddWithValue("image", product.ImagePath);
                    command.Parameters.AddWithValue("stock", product.Stock);
                    command.Parameters.AddWithValue("expired", product.ExpiredDate.Date);

                    return (int)command.ExecuteScalar();
                }
            }
        }*/

        // Tambahkan di DatabaseHelper.cs
        /*public ProductItem GetProductById(string productId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM products WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", productId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ProductItem
                            {
                                ID = reader.GetString(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                ImagePath = reader.GetString(3),
                                Stock = reader.GetInt32(4),
                                ExpiredDate = reader.GetDateTime(5)
                            };
                        }
                    }
                }
            }
            return null;
        }*/

        /*public int UpdateProduct(ProductItem product)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT st_update(@id, @name, @description, @image, @stock, @expired::date)", connection))
                {
                    command.Parameters.AddWithValue("id", product.ID);
                    command.Parameters.AddWithValue("name", product.Name);
                    command.Parameters.AddWithValue("description", product.Description);
                    command.Parameters.AddWithValue("image", product.ImagePath);
                    command.Parameters.AddWithValue("stock", product.Stock);
                    command.Parameters.AddWithValue("expired", product.ExpiredDate.Date);

                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }*/

        /* public List<ProductItem> GetProducts()
         {
             List<ProductItem> products = new List<ProductItem>();
             string query = "SELECT * FROM st_select();";

             using (var connection = new NpgsqlConnection(_connectionString))
             {
                 connection.Open();
                 using (var command = new NpgsqlCommand(query, connection))
                 {
                     using (NpgsqlDataReader reader = command.ExecuteReader())
                     {
                         while (reader.Read())
                         {
                             ProductItem product = new ProductItem
                             {
                                 ID = reader["id_product"].ToString(),
                                 Name = reader["name_product"].ToString(),
                                 Description = reader["description_product"].ToString(),
                                 ImagePath = reader["image_path_product"].ToString(),
                                 Stock = Convert.ToInt32(reader["stock_product"]),
                                 ExpiredDate = Convert.ToDateTime(reader["expired_date_product"])
                             };
                             products.Add(product);
                         }
                     }
                 }
             }
             return products;
         }*/

        /*public int DeleteProduct(string productId)
        {
            using(var connection = new NpgsqlConnection(_connectionString))
    {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT st_delete(@id)", connection)) // Memanggil fungsi st_delete
                {
                    command.Parameters.AddWithValue("id", productId);
                    // Di sini kita tidak perlu menggunakan ExecuteNonQuery, kita bisa langsung memanggil fungsi yang tidak mengembalikan hasil
                    try
                    {
                        command.ExecuteNonQuery(); // Menjalankan fungsi
                        return 1; // Mengembalikan nilai 1 jika berhasil
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}"); // Menangkap error jika ada
                        return 0; // Mengembalikan 0 jika gagal
                    }
                }
            }
        }*/

        public bool IsUsernameAvailable(string username)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM akun WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; // Jika count == 0, maka username belum ada
                }
            }
        }

        public void RegisterUser(string email, string nomorHp, string username, string password, string role)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO akun (email, nomor_hp, username, password, role) VALUES (@Email, @NomorHp, @Username, @Password, @Role)", conn))
                {
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("NomorHp", nomorHp);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("Password", password); // Pastikan password sudah di-hash sebelum disimpan
                    cmd.Parameters.AddWithValue("Role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string LoginUser(string username, string password)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT password, role FROM akun WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader.GetString(0); // Mendapatkan password terenkripsi dari database
                            string role = reader.GetString(1);           // Mendapatkan role dari database

                            // Verifikasi password dengan BCrypt
                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                                return role; // Mengembalikan role jika login berhasil
                            }
                            else
                            {
                                return "wrong_password"; // Mengembalikan pesan jika password salah
                            }
                        }
                        else
                        {
                            return "not_found"; // Mengembalikan pesan jika username tidak ditemukan
                        }
                    }
                }
            }
        }


        public bool UpdateProfile(string currentUsername, string currentPassword, string newUsername, string newPassword, string email, string location, string aboutMe)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT password, role FROM akun WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("username", currentUsername);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Username ditemukan, ambil password terenkripsi dan role
                            string hashedPassword = reader.GetString(0);
                            string role = reader.GetString(1);

                            // Verifikasi password menggunakan BCrypt
                            if (BCrypt.Net.BCrypt.Verify(currentPassword, hashedPassword))
                            {
                                reader.Close(); // Tutup reader sebelum memulai update

                                // Hash password baru jika ada perubahan
                                string newHashedPassword = !string.IsNullOrEmpty(newPassword) ? BCrypt.Net.BCrypt.HashPassword(newPassword) : hashedPassword;

                                // Update data di tabel sesuai role (pemberi atau penerima)
                                string updateQuery;
                                if (role == "pemberi")
                                {
                                    updateQuery = "UPDATE pemberi SET username = @newUsername, password = @newPassword, email = @newEmail, location = @location, about_me = @aboutMe WHERE username = @username";
                                }
                                else if (role == "penerima")
                                {
                                    updateQuery = "UPDATE penerima SET username = @newUsername, password = @newPassword, email = @newEmail, location = @location, about_me = @aboutMe WHERE username = @username";
                                }
                                else
                                {
                                    return false; // Role tidak valid
                                }

                                using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("newUsername", newUsername);
                                    updateCmd.Parameters.AddWithValue("newPassword", newHashedPassword);
                                    updateCmd.Parameters.AddWithValue("newEmail", email);
                                    updateCmd.Parameters.AddWithValue("location", location);
                                    updateCmd.Parameters.AddWithValue("aboutMe", aboutMe);
                                    updateCmd.Parameters.AddWithValue("username", currentUsername);

                                    updateCmd.ExecuteNonQuery();
                                    return true; // Berhasil update
                                }
                            }
                            else
                            {
                                // Password salah
                                return false;
                            }
                        }
                        else
                        {
                            // Username tidak ditemukan
                            return false;
                        }
                    }
                }
            }
        }


        public (string email, string? location, string? aboutMe) GetUserProfile(string username)
        {
            // Ensure username is not null or empty
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be null or empty", nameof(username));
            }

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT a.email, p.location, p.about_me FROM akun a LEFT JOIN pemberi p ON a.username = p.username WHERE a.username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Always retrieve email
                            string email = reader.GetString(0); // This should always exist

                            // Retrieve location and aboutMe, allowing them to be null
                            string? location = reader.IsDBNull(1) ? null : reader.GetString(1);
                            string? aboutMe = reader.IsDBNull(2) ? null : reader.GetString(2);

                            return (email, location, aboutMe);
                        }
                    }
                }
            }

            throw new KeyNotFoundException("User profile not found for the given username."); // If no results found
        }


        public void SaveApprovedRequest(string productName, string giver, string receiver, int slot, string place, DateTime requestedDate)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO request (product_name, giver, receiver, slot, pickup_date, place) VALUES (@product_name, @giver, @receiver, @slot, @pickup_date, @place)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@giver", giver);
                        cmd.Parameters.AddWithValue("@receiver", receiver);
                        cmd.Parameters.AddWithValue("@slot", slot);
                        cmd.Parameters.AddWithValue("@pickup_date", requestedDate);
                        cmd.Parameters.AddWithValue("@place", place); // Menambahkan parameter untuk 'place'

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Request telah disetujui.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error persetujuan request: " + ex.Message);
                }
            }
        }


        public bool IsUserGiver(string username)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM akun WHERE username = @username AND role = 'pemberi'";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Jika ada, kembalikan true
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking user role: " + ex.Message);
                    return false; // Jika terjadi error, anggap tidak valid
                }
            }
        }



    }
}