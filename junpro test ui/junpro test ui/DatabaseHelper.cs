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

        public int InsertProduct(ProductItem product)
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
        }

        // Tambahkan di DatabaseHelper.cs
        public ProductItem GetProductById(string productId)
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
        }

        public int UpdateProduct(ProductItem product)
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
        }

        public List<ProductItem> GetProducts()
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
        }

        public int DeleteProduct(string productId)
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
        }

    }
}